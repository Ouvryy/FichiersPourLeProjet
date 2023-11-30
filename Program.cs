// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
n=10// nombres de coups
Random rnd = new Random();

int[] BackFront(int n)
{
    void InitilisationPartie()
    {
        int[] grille= new int[]{{0,0,0,0};{0,0,0,0};{0,0,0,0};{0,0,0,0}};
        int nb1 = rng.next(0,3);
        int nb2 = rng.next(0,3);
        int nb3 = rng.next(0,3);
        int nb4 = rng.next(0,3);
        if (nb1==nb3 and nb2==nb4)
        {
            while(nb1==nb3 and nb2==nb4)
            {
                nb4=rng.next(0,3);
            }
        }
        grille[nb1][nb2]=1;
        grille[nb3][nb4]=1;
        
    }
    int input = Convert.ToInt32(Console.ReadLine()!);
    if(input==8)
    {
        //on vérifie que c'est possible
        for(int k=0;k<3;k++)
        {  
            for(int j=0;j<3;j++)
            {
                if(grille[j][k]==grill[j+1][k])
                {
                    grille[j+1][k]= grille[j+1][k]*2;//clement ez ibra
                }
            } 
        } 
        
    }
}
        
    
    
    