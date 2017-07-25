
package turtle;

import java.io.File;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class searchScope {
    public static void search(){
        Scanner input = new Scanner(System.in);
        System.out.println("Enter a directory to search");
        String search;
        search = input.next();
        File currentDir = new File(search);
        for(File f : currentDir.listFiles()){
            if(f.getName().contains(search)){ // <-- search is the entered search request
            System.out.println(f.getName());
            }
        }      
        ArrayList<File> files = new ArrayList<>(Arrays.asList(currentDir.listFiles()));
        files.forEach(System.out::println);
        
        String fileType;
        System.out.println("Enter a file extension: ");
        fileType = input.next();
        
        File dir = new File(search);
        for(File f : dir.listFiles()){
            if(f.getName().contains(fileType)){
            System.out.println(f.getName());
            }
        }
    }
}
