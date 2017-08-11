Abstraction is a process where you show only “relevant” data and “hide” unnecessary details of an object from the user. Consider your mobile phone, you just need to know what buttons are to be pressed to send a message or make a call, What happens when you press a button, how your messages are sent, how your calls are connected is all abstracted away from the user.

Encapsulation is the process of combining data and functions into a single unit called class. In Encapsulation, the data is not accessed directly; it is accessed through the functions present inside the class. In simpler words, attributes of the class are kept private and public getter and setter methods are provided to manipulate these attributes. Thus, encapsulation makes the concept of data hiding possible.

```c#
public abstract class Draw {
    public abstract void drawShape(); // this is abstraction.  Implementation detail need not to be known.
    // so we are providing only necessary detail by giving drawShape(); No implementation. Subclass will give detail.


    private int type;    // this variable cannot be set outside of the class. Because it is private.
    // Binding private instance variable with public setter/getter method is encapsulation 

    public int getType() { 
        return type;
    }

    public void setType(int type) {  // this is encapsulation. Protecting any value to be set.
        if (type >= 0 && type <= 3) {
            this.type = type;
        } else {
            System.out.println("We have four types only. Enter value between 0 to 4");
            try {
                throw new MyInvalidValueSetException();
            } catch (MyInvalidValueSetException e) {
                e.printStackTrace();
            }

        }
    }
}
```
