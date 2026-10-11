class student
{	
	public string Name { get; set;}
}


class Teacher
{
	public string Name { get; set;}
	public int age { get; set;}
	
}

class Course
{
	public string Title { get; set; }
	public int Duration { get; set; }
}

class Shape
{
    public double Width;
    public double Height;
}

class square
{
	public int side { get; set; }
	public string color { get; set; }
}

class rectangle
{
	public int bigside { get; set; }
	public int smallside { get; set; }
	public string color { get; set; }
}

class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}

class Factor
{
    public int Number { get; set; }
    public string Date { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }
}
