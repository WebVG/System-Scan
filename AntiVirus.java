package turtle;

import javax.swing.*;   // design imports //
import java.awt.*;      // design //
import java.awt.event.*;
import java.io.*;

public class AntiVirus extends JFrame implements Runnable {

    File[] myfile;
    int directories_count = 0;      // counts the systems dir // 
    JTextField t_field = new JTextField("", 50); // for file name //
    JTextArea t_area = new JTextArea(); // for displaying directories //
    JLabel file_label = new JLabel("File Name  :"); // for file name label //
    JLabel dir_label = new JLabel("Directory  :"); // for displaying //
    JLabel status = new JLabel("Status: Ready"); // current status //
    JScrollPane sp = new JScrollPane(t_area); // scroll bars in text //
    JComboBox jcb = new JComboBox(); // a combo box //
    JButton cleanVirus = new JButton("Clean Virus");

    String file_name;   // stores the file name //
    String dir;         // stores the direcotry name //
    boolean deleted = false;    // changes status //

    AntiVirus() {

        directories_count = File.listRoots().length; // counting total disk drives //
        myfile = File.listRoots(); // a file object for storing root names //

        for (int i = 0; i < directories_count; i++) {
            jcb.addItem(myfile[i]); // adding directories in combobox
        }
        JPanel up = new JPanel(); // making a new panel to add north //
        add(up, "North");         // adding panel in north position //
        up.add(file_label);       // first adding file name label //
        up.add(t_field);          // text field to enter file name //
        up.add(dir_label);        // dircotry label; //
        up.add(jcb);              // combo box //
        up.add(status);           // status label //
        up.add(cleanVirus);       // search button //

        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(1024, 700); // frame size //
        setVisible(true);

        add(sp); // scrolling pane //

        cleanVirus.addMouseListener(new MouseAdapter() {

            public void mouseClicked(MouseEvent me) { //overriding				

                file_name = t_field.getText();// getting the text from text field
                dir = jcb.getSelectedItem().toString(); // directory selected from combo box
                dir += "\\";    //appending double slashes to dir e.g C:\\		status.setText("Finding Virus"); //setting the status
                startThread(); //creating a new thread using this function
            }
        }); // end anonymous class and mouselistener
    }

    public void startThread() {
        Thread t = new Thread(this);
        t.start();
    }

    @Override
    public void run() {
        try {
            DeleteVirus(file_name, new File(dir));
            if (deleted == true) {
                status.setText("Virus Deleted");
            } else {
                status.setText("No Virus ");
            }
        } catch (Exception e) {

        }
    }

    public void DeleteVirus(String v_dir, File v) {

        File[] list = v.listFiles();

        if (list != null) {
            for (File subfile : list) {

                t_area.append("" + v.getAbsolutePath());
                t_area.append("\n");

                File v_file = new File(v.getAbsolutePath(), file_name);

                if (v_file.isFile()) {
                    v_file.delete();
                    deleted = true;
                }
                if (subfile.isDirectory()) {
                    DeleteVirus(v_dir, subfile);
                }
            }
        }
    }
    
    public static void main(String args[]){
        new AntiVirus();
    }
}
