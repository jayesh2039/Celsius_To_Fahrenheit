class Person:
    def getdata(self):
        c = int(input("Enter Celsius Value : "))
        return c
class Person2(Person):
    def putdata(self,c):
        f = (c * 9/5)+32
        print("The Value Of Celsius To Fahrenheit Is : ",f)

op2 = Person2 ()

op2.f = op2.getdata()
op2.putdata(op2.f)