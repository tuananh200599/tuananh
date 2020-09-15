namespace StaticProperty
{
    public class Car
    {
private string name;
 private string engine;
 public static int numberOfCars;
 public Car(string _name, string _engine) {
 this.name = _name;
 this.engine = _engine;
 numberOfCars++;
 }
 public string GetName()
{
     return this.name;
}

public void SetName(string _name)
{
     this.name = _name;
}
 public string GetEngine()
{
     return this.engine;
}

public void SetEngine(string _engine)
{
     this.engine = _engine;
}

 
public override string ToString()
{
     return "name : " + name + " engine : " + engine ;
}
 
}
    }
