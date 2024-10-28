using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100.LectureNotes
{
    internal class Notes
    {
        /*
         
        WEEK 5
        How are lists stored?
        - not like arrays, arrays are stored one by one, even 2d arrays
        - lists have chunked data, not necessarily stored in memory all in a row
        
        Why list vs arrays?
        - with arrays, they are imutable, cannot change the length once defined, stored one by one
        - lists are good when dealing with uncertain data length since they are MUTABLE, and since the data
          storage isnt right next to eachother
        - if we have a fixed number thing we need, ALWAYS choose arrays since its faster memory wise since 
          all the data is right there. We use lists for uncertain data lengths since they can increase/decrease
        
        Data Structures
        - Stacks:
            - FILO: first in last out
            - think of stacking things on top of eachother, the most recent one is on top
        - How to impliment stack?
            - most times you want to use a list when using stacks becasue the length can vary, can cause
              issues with arrays due to their fixed length
        - Common Commands:
            - Push(object): adds an element to the top of the Stack
            - Pop(): gets the value at the top of the Stack, and removes it
            - Peek: gets the value at the top of the Stack, but does not remove it
            - Clear: removes all elements from the Queue

        - Queues:
            - FIFO: first in first out
            - think of waiting in line, the first person in line is the first person to get served
        
        - Common Commands:
            - Enqueue(object) – adds an element to the end of the Queue
            - Dequeue() – gets the value at the front of the Queue and removes it from the Queue
            - Peek – gets the value at the front of the Queue, but does not remove it
            - Clear – removes all elements from the Queue



         */

        /*
     
        WEEK 6
        - What is a Linked List?
            - Sequence of elements
            - Definition: A linked list is a sequence of elements, known as nodes
                          where each node is connected to the subsequent node via a pointer
        - Classes
            - data structure that combine data variables and functions into a sigle unit
            - basically the blueprint for creating objects
            - Why do we need classes?
                - let us model and interact with real-world entities in our code
                - can make multiple objects within a class

            - Syntax:
                - {AccessSpecifier} class {className}
                - Access specifiers are things like public, private, protected

            - Public, private, protected? -->
                - public: accessible everywhere, 
                - private: accessible in the class only
                - protected: accessible within the class and derived classes

            - Static?
                - a type of class that cannot be instantiated
                - Syntax:
                    - static class {className}
                - We cannot create an object of the static class.
                - A static class cannot be inherited.
                - It allows only a static constructor to be declared.
                - The static class methods can be called using the class name without creating the instance.
        
        - Objects
            - An object is a dynamically created instance of the class - created at runtime
            - All the members of the class can be accessed using the object
            - Syntax:
                - {className} objectName = new {className}();

        - Takeaway from todays lecture: DataBinding is OP when you can use it otherwise
          you have to manually bind everything :( (used on assignment 3)


        WEEK 7
        - Method Overloading
            - Method overloading allows for you to declare multiple methods within the same class
            - Ex. if we want to make an add function, we can make a function that takes both int and doubles
                - Two seperarte methods, using two different data types within the same class
        
        - Constructor Overloading
            - Lets the class have multiple constructors
            - These constructors can have different parameters, lets objects be initalized differently
            
        - Encapsulation
            - Helps to maintain data integrity by controlling the access to to the data
            - Refers to the bundling of data (attributes) and the methods (functions) that operate on data into agle unit (a class)
            - Provides a way to restrict unauthorized access and modification of an object's state
   
        - Inheritance
            - Concept that allows a class to inherit behaviour from another class
            - 
        */

    }

}
