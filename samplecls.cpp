#include<iostream>// preprocessor directive to include the iostream header file in our program 
//during compilation
using namespace std; // specifying the namespace to avoid name conflicts

// defining our class

// <class keyword> <Name of the class>


class sample{
// adding fields to the class
public: // our fields are now public
int number;
float dec;
// the fields li have declared above are private by default therefore they can'e be accessed outsied this clas let's specify access as public

//declaring the methods inside the class
// methods are functions defined inside a class
// this method is also private by default let's make it public
public:
int add(int num1, int num2){

return num1+num2;
}
}; // don't forget to terminate the body of the class with a semicolon

//declaring our main function where programm execution id going to begin

int main(){
// creating objects of the sample class
// syntax:  <class Name>  <object name>;

sample obj;//it musn't be obj it could be any name even yours


// creating a variable inside main
int nums;
// assigning the value gotten from the add function in main to the variable nums courtesy of
// the obj object.
nums=obj.add(12,78);

// printing to the console
cout<<nums; //output expected is 90

    return 90; // main should return a value of type int is 90 not int
}