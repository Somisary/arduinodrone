void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
}

void loop() {
  int value = analogRead(0);
  Serial.println(value>>2);
  delay(1000);        // delay in between reads for stability
}
