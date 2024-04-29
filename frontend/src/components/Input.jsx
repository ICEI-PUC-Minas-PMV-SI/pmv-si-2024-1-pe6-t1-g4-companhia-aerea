/* eslint-disable react/prop-types */
function Input({ type = "text", placeholder, value, onChange, label }) {
    return (
        <div className="d-flex flex-column">
        {label && <label>{label}</label>}
        <input
          type={type}
          placeholder={placeholder}
          value={value}
          onChange={onChange}
        />
      </div>
      );
}

export default Input;