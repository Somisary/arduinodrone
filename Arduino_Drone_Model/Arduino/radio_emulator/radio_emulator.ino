void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
}

void loop() {
  Serial.println(8);
  delay(100);        // delay in between reads for stability
}
