Console.Write("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha") {
    Console.WriteLine("Hello, Masha. How are doing today?");
} 

else {
    Console.WriteLine("Hello");
    Console.WriteLine(username);
}