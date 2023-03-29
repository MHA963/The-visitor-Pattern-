# SWD - The Visitor Pattern 
Working with SOLID principales and the visitor pattern 

## Design 
Working on the design example from [Geek Culture](https://medium.com/geekculture/design-pattern-visitor-pattern-the-most-complicated-design-pattern-with-c-code-sample-f88b608ffb4a)
Expanded Class diagram for the design provided in the example
### Class Diagram
This is a class diagram that illustrates the relationships between the classes involved in a simple insurance system. The system is designed to allow clients to purchase different types of insurance plans, including car, truck, motorbike, and bike insurance plans. The diagram shows the different classes involved in the system and their relationships.
![Alt text](/Diagrams/CD_1.png)


```mermaid
classDiagram
    
    class Client{

    }
    
    class IVisitor{
        <<interface>>
        +VisitCarInsurance(CarInsurance Insurance)
        +VisitTruckInsurance(TruckInsurance Insurance)
        +VisitBikeInsurance(CarInsurance Insurance)
        +VisitMotorBikeInsurance(TruckInsurance Insurance)
    }
    
    class IInsurance{
        <<interface>>
        +Accept(Visitor)
        +GetCost()
        +GetCommunication()
    }
    class TruckInsurance{
        +Accept(Visitor)
        +GetCost()
        +GetCommunication()
    }
    
    class CarInsurance{
        +Accept(Visitor)
        +GetCost()
        +GetCommunication()
    }
    class MotorBikeInsurance{
        +Accept(Visitor)
        
        +GetCost()
        +GetCommunication()
    }
    class BikeInsurance{
        +Accept(Visitor)
        +GetCost()
        +GetCommunication()
    }

    
    class TypeVisitor{
       +VisitCarInsurance(CarInsurance Insurance)
        +VisitTruckInsurance(TruckInsurance Insurance)
        +VisitBikeInsurance(CarInsurance Insurance)
        +VisitMotorBikeInsurance(TruckInsurance Insurance)    
    }
    class CommunicationVisitor{
       +VisitCarInsurance(CarInsurance Insurance)
        +VisitTruckInsurance(TruckInsurance Insurance)
        +VisitBikeInsurance(CarInsurance Insurance)
        +VisitMotorBikeInsurance(TruckInsurance Insurance)
    } 

    TypeVisitor ..|> IVisitor
    CommunicationVisitor ..|> IVisitor
    Client --> IInsurance
    Client --> IVisitor
    TruckInsurance --|> IInsurance
    BikeInsurance --|> IInsurance
    MotorBikeInsurance --|> IInsurance
    CarInsurance --|> IInsurance
    TruckInsurance --> IVisitor
    BikeInsurance --> IVisitor
    MotorBikeInsurance --> IVisitor 
    CarInsurance --> IVisitor       
```





### Sequence Diagram
```mermaid
sequenceDiagram
    participant Client
    participant IVisitor
    participant TypeVisitor
    participant CCVisitor
    participant IInsurance
    participant CarInsurance
    
    Client->>IVisitor: VisitCarInsurance(CarInsurance)
    IVisitor->>TypeVisitor: VisitCarInsurance(CarInsurance)
    
    TypeVisitor->>CarInsurance: Accept(visitor)    
    
    activate CarInsurance
    CarInsurance-->>IVisitor: GetCost()
    deactivate CarInsurance

    Client->>IVisitor: VisitCarInsurance(CarInsurance)
    IVisitor->>CCVisitor: VisitCarInsurance(CarInsurance)
    CCVisitor->>CarInsurance: Accept(visitor) 

    activate CarInsurance
    CarInsurance-->>IVisitor: GetCommunication()
    deactivate CarInsurance
```

    
