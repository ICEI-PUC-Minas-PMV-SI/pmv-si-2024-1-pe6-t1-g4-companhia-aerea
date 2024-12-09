from flask import Flask, make_response, request, jsonify
from flask_cors import CORS
import pandas as pd
import joblib
from data.cars import car_models
from data.keys import keys
import sys
import os

# Add the 'data' directory to the Python path dynamically
sys.path.append(os.path.join(os.path.dirname(__file__), 'data'))

app = Flask(__name__)

# Enable CORS for all routes globally
CORS(app)

model = joblib.load('random_forest_model.pkl')
preprocessor = joblib.load('preprocessor.pkl')

database = 'test.csv'

@app.route('/predict', methods=['POST'])
def predict():
    try:
        data = request.get_json(force=True)     
        make = data.get('make')
        model_name = data.get('model')

        if make not in car_models:
            return jsonify({'error': f'Unknown car make: {make}'}), 400
        
        models = car_models[make]
        
        car_id = None
        for idx, car in enumerate(models):
            if car['code'] == model_name:
                car_id = idx + 1 
                break
        
        if car_id is None:
            return jsonify({'error': f'Unknown model: {model_name} for make: {make}'}), 400
                
        df = pd.read_csv(database)
        
        if car_id < 1 or car_id > len(df):
            return jsonify({'error': f"Car ID {car_id} is out of range."}), 400
        
        car_row = df.iloc[car_id - 1]
        
        new_data = {}
        for key in keys:
            if key in car_row:
                new_data[key] = [car_row[key]]
        
        new_data_df = pd.DataFrame(new_data)

        new_data_df['policy_tenure'] = pd.to_numeric(new_data_df['policy_tenure'], errors='coerce')
        new_data_df['age_of_car'] = pd.to_numeric(new_data_df['age_of_car'], errors='coerce')
        new_data_df['age_of_policyholder'] = pd.to_numeric(new_data_df['age_of_policyholder'], errors='coerce')
        new_data_df['displacement'] = pd.to_numeric(new_data_df['displacement'], errors='coerce')

        new_data_df['max_torque'] = new_data_df['max_torque'].str.extract('(\d+\.?\d*)').astype(float)
        new_data_df['max_power'] = new_data_df['max_power'].str.extract('(\d+\.?\d*)').astype(float)

        new_data_transformed = preprocessor.transform(new_data_df)

        prediction = model.predict(new_data_transformed)

        probability = model.predict_proba(new_data_transformed)

        response = {
            "prediction": prediction.tolist(),
            "probability": [probability[0].tolist()]
        }
        
        # Manually adding CORS headers (Optional if using flask-cors)
        response_obj = jsonify(response)
        response_obj.headers.add("Access-Control-Allow-Origin", "*")
        return response_obj
    
    except Exception as e:
        return jsonify({'error': str(e)}), 400

# Run the app
if __name__ == '__main__':
    app.run(debug=True)
