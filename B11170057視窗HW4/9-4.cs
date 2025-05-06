using System;

public class PhoneList
{
    public string HomePhone { get; set; }
    public string BusinessPhone { get; set; }
    public string CellPhone { get; set; }

    public PhoneList(string homePhone, string businessPhone, string cellPhone)
    {
        HomePhone = homePhone;
        BusinessPhone = businessPhone;
        CellPhone = cellPhone;
    }

    public override string ToString()
    {
        return $"Home: {HomePhone}, Business: {BusinessPhone}, Cell: {CellPhone}";
    }
}

public class Cards
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public PhoneList Phone { get; set; }

    public Cards(string name, string occupation, int age, string email, PhoneList phone)
    {
        Name = name;
        Occupation = occupation;
        Age = age;
        Email = email;
        Phone = phone;
    }

    public string GetCard()
    {
        return $"Name: {Name}\n" +
               $"Occupation: {Occupation}\n" +
               $"Age: {Age}\n" +
               $"Email: {Email}\n" +
               $"Phone Numbers:\n  {Phone}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhoneList phoneList = new PhoneList("0968830329", "0955155031", "0921093909");
            Cards myCard = new Cards("徐偉晟", "大學生", 21, "a0968830329@gmail.com", phoneList);

            Console.WriteLine(myCard.GetCard());
        }
    }

}
