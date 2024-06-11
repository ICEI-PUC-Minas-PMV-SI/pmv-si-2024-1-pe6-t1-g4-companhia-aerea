import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, View } from 'react-native';
import { WebView } from 'react-native-webview';

export default function App() {
  return (
    <>
      <View style={styles.container}>
    </View>
    <WebView source={{ uri: 'https://6668a212d350b42643460cd4--statuesque-biscuit-064fe0.netlify.app/' }}  />
    </>
  
  );
}

const styles = StyleSheet.create({
  container: {
   height:45,
   backgroundColor:'black',
  },
});
