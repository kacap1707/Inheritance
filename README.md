# Inheritance

Here are some good examples explaining the process of inheritance in C#.

In #FinancialOrganizations folder you'll see a basic FinancialInstitution class which will "give birth" to `Bank`s, `Credit organization`s and `Insurance company`ies.
All those institutions inherite all fields, properties and methods from base class. Meanwhile, they also add their own specific states and functionalities.

For example:  
```javascript
public long Assets { get; set; }
public long Liabilities { get; set; } 
```
these properties are particular for Banks, so we add them in derived class(Bank).

In TestingPolygon, the client adds our class library reference in his/her project and employs.
