 string mes1 = "08 - agosto";
        string mes2 = "09 - setembro";
        string mes3 = "10 - outubro";
        
        
        
        
        Console.WriteLine ("Atividade- Aula 06");
        Console.WriteLine ("Ola, seja bem-vindo a agencia Globo de passagens aereas! ");
        Console.WriteLine("Segue abaixo as tres opcoes de meses disponiveis para compra de passagens:");
        Console.Write($" {mes1}");
        Console.WriteLine($" {mes2}");
        Console.WriteLine($" {mes3}");
        
        Console.WriteLine($"Por favor digite o mes de sua preferencia:");
         
         if (mes1== 08)
         {
             Console.WriteLine("mes1 08 selecionado");
         }
         else if (mes2== 09)
         {
            Console.WriteLine("mes2 09 selecionado");
         }
         else if (mes3== 10)
         {
         Console.WriteLine("mes3 10 selecionado");
         }
         else 
         {
             Console.WriteLine("mes invalido");
             Main (null);
             return;
         }
