const int LedPin = 3;  
int ledState = 0; 
String receiveVal = String(); 
bool stringComplete;
  
void setup()  
{   
   pinMode(LedPin, OUTPUT);  
   Serial.begin(9600);   
   receiveVal.reserve(255);
}  
  
void loop()  
{     
     
    if(stringComplete)
    {
       stringComplete = false;
    }

      if(receiveVal != "")
      {
         Serial.println(receiveVal);
      
      
         if(receiveVal.toInt() == 1) 
         {    
             ledState = HIGH;
         }     
       
         if(receiveVal.toInt() == 0)
         {  
             ledState = LOW;
         }
      }         
   
        
    digitalWrite(LedPin, ledState);   
    
    receiveVal = "";
    delay(1000); 

}

/*   Serial Event Handler */
void serialEvent()
{
   while(Serial.available())
   {
      //get byte
      char inChar = (char)Serial.read();
      receiveVal += inChar;
      if(inChar == '\n')
      {
         stringComplete = true;
      }
   }
}