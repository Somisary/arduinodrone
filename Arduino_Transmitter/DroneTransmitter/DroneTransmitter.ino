/*
  AnalogReadSerial
  Reads an analog input on pin 0, prints the result to the serial monitor.
  Graphical representation is available using serial plotter (Tools > Serial Plotter menu)
  Attach the center pin of a potentiometer to pin A0, and the outside pins to +5V and ground.
*/

// the setup routine runs once when you press reset:
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
}

// the loop routine runs over and over again forever:
void loop() {
  // read the input on analog pin 0:
  unsigned int sensorValue1 = (float)analogRead(A0)*(254.0f/1024.0f);
  unsigned int sensorValue2 = (float)analogRead(A3)*(254.0f/1024.0f);
  // print out the value you read:
  Serial.write(sensorValue1);
  Serial.write(255);
  Serial.write(sensorValue2);
  delay(200);        // delay in between reads for stability
}
