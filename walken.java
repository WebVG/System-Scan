
package turtle;

import java.io.File;
public class cookieBag {
    /***
     * Walks the target directory.
     * @param path 
     */
    public void walk( String path ) {

        File root = new File( path );
        File[] list = root.listFiles();

        if (list == null) return;

        for ( File f : list ) {
            if ( f.isDirectory() ) {
                walk( f.getAbsolutePath() );
                System.out.println( "Dir:" + f.getAbsoluteFile());
            }
            else {
                System.out.println( "File:" + f.getAbsoluteFile() );
            }
        }
    }   
}

