//interacion
Console.WriteLine("señor cliente colo que su nombre, por favor");
string Cliente = Console.ReadLine();

string[] menuComida = new string[5] {"perro caliente", "pizza", "lazalla", "ensalada", "helado"};
string[] menuBebida = new string[8] {"postobon", "cocacola", "pepsi", "maltiada de vanilla", "maltiada de chocolate", "jugo de naranja", "jugo de fresa", "jugo de uva"};
//bienvinda y el menu
Console.WriteLine("bienvenido al restuarante sabergerl señor "+Cliente);
Console.WriteLine("tome el menu de comidas");
Console.WriteLine($"-{menuComida[0]} -{menuComida[1]} -{menuComida[2]} -{menuComida[3]}    -{menuComida[4]}\n");
Console.WriteLine("tome el menu de bebidas");
Console.WriteLine($"-{menuBebida[0]} -{menuBebida[1]} -{menuBebida[2]} -{menuBebida[3]} -{menuBebida[4]} -{menuBebida[5]} -{menuBebida[6]} -{menuBebida[7]}\n");

Console.WriteLine(Cliente+" ¿que desea comida o una bebida?(escriba la bebida o la comida que desea sino quire escriba nada");
Console.WriteLine("eliga la comida");
string menu = Console.ReadLine();
Console.WriteLine("eliga la bebida");
string soda = Console.ReadLine();



switch (soda)
{
        case "postobon":
            string mensaje = "tome su postobon";
            Console.WriteLine(mensaje + " de $10 dolares");
            break;
        case "cocacola":
            string mensaje1 = "tome su cocacola";
            Console.WriteLine(mensaje1 + " de $9 dolares");
            break;
        case "pepsi":
            string mensaje2 = "tome su pespi";
            Console.WriteLine(mensaje2 + " de $8 dolares");
            break;
        case "maltiada de vainilla":
            string mensaje3 = "tome su maltiada de vainilla";
            Console.WriteLine(mensaje3 + " de $12 dolares");
            break;
        case "maltiada de chocolate":
            string mensaje4 = "tome su maltiada de chocolate";
            Console.WriteLine(mensaje4 + " de $14 dolares");
            break;
        case "jugo de naranja":
            string mensaje5 = "tome su jugo de naranja ";
            Console.WriteLine(mensaje5 + " de $5 dolares");
            break;
        case "jugo de fresa":
            string mensaje6 = "tome su jugo de fresa ";
            Console.WriteLine(mensaje6 + " de $4 dolares");
            break;
        case "jugo de uva":
            string mensaje7 = "tome su jugo de uva ";
            Console.WriteLine(mensaje7 + " de $5 dolares");
            break;
        default: 
        if (soda == "nada")
        {
            Console.WriteLine(Cliente + " gracias por visitarnos");
            Environment.Exit(0);
        }
        Console.WriteLine("hubo un error coloque todo en minuscula");
        break;
}
switch (menu)
{
    case "perro caliente":
        string mensaje = "tome su perro caliente";
        Console.WriteLine(mensaje + " de $3 dolares");
        break;
    case "pizza":
        string mensaje1 = "tome su pizza";
        Console.WriteLine(mensaje1 + " de $3 dolares");
        break;
    case "lazalla":
        string mensaje2 = "tome su perro caliente";
        Console.WriteLine(mensaje2 + " de $3 dolares");
        break;
    case "ensalada":
        string mensaje3 = "tome su ensalada";
        Console.WriteLine(mensaje3 + " de $3 dolares");
        break;
    case "helado":
        string mensaje4 = "tome su helado";
        Console.WriteLine(mensaje4 + " de $3 dolares");
        break;
    default:
        Console.WriteLine(Cliente+ " por favor escriba en minuzcula y respete los espacios, por favor");
        if(menu == "nada")
        {
            Console.WriteLine(Cliente+" gracias por visitarnos");
            Environment.Exit(0);
        }
        Console.WriteLine(Cliente + " por favor escriba en minuzcula y respete los espacios, por favor");
        break;

}
