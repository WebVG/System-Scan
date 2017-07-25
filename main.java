package turtle;

import java.util.Scanner;


public class main{
    public static class progIn{
        
        public void menu(){
            System.out.println("1.) searchScope" + "\n2.) connect" + "\n3.) Collect Cookies");
        }
    }
    public static void main(String[] args){
        progIn x = new progIn();
        Scanner input = new Scanner(System.in);
        int option = 0;
        do{
            x.menu();
            option = input.nextInt();
            switch (option) {
                case 0:
                    x.menu();
                case 1:
                    System.out.println("searchScope started: ");
                    searchScope.search();
                    break;
                case 2:
                    // entere password thign here
                    break;
                case 3:
                    System.out.println("::: Cookies :::");
                    cookieBag cb = new cookieBag();
                    cb.walk("C:\\Users\\Garrett\\AppData\\Roaming");
                    break;
            }
        }while(option != 6);
    }
}
