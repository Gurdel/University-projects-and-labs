import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Lab4sp {
    public static void main(String[] args) throws IOException {
        List<String> linesA = Files.readAllLines(Paths.get("input.txt"), Charset.defaultCharset());
        String e = linesA.get(0); //порожній символ
        linesA.remove(0);

        //заповнення множин нетерміналів nt і правил виведення p
        ArrayList<String> nt = new ArrayList<>();
        ArrayList<ArrayList<String>> p = new ArrayList<>();
        for(String s : linesA){
            String[] buf = s.split("->");
            nt.add(buf[0]);
            ArrayList<String> b = new ArrayList<>(Arrays.asList(buf[1].split(" ")));
            p.add(b);
        }

        ArrayList<ArrayList<Integer>> vivid = new ArrayList<>();
        ArrayList<Integer> b = new ArrayList<>();
        b.add(-1);
        vivid.add(b);
        String cur = nt.get(0);
        String start = cur;
        ArrayList<String> words = new ArrayList<>();
        ArrayList<String> alsoCheckNT = new ArrayList<>();
        ArrayList<String> alsoCheckWords = new ArrayList<>();
        ArrayList<ArrayList<Integer>> alsoCheckVivid = new ArrayList<>();
        alsoCheckNT.add(cur);
        words.add(cur);
        boolean cont = true;
        while (words.size() != 0 && cont){
            ArrayList<ArrayList<Integer>> nextVivid = new ArrayList<>();
            ArrayList<String> nextWords = new ArrayList<>();
            for (int i = 0; i < words.size(); ++i){
                String bw = words.get(i);
                String t = bw.substring(0, 1);
                int rulNumb = nt.indexOf(t);
                if(rulNumb != -1){
                    ArrayList<String> rules = p.get(rulNumb);

                    for (String s : rules){
                        ArrayList<Integer> bviv = new ArrayList<>(vivid.get(i));
                        if(!s.equals(e)){
                            if (!bviv.contains(rulNumb)) {
                                nextWords.add(s + bw.substring(1));
                                bviv.add(rulNumb);
                                nextVivid.add(bviv);
                            }
                        }
                        else {
                            nextWords.add(bw.substring(1));
                            bviv.add((rulNumb+1)*(-1));
                            nextVivid.add(bviv);
                        }
                    }
                }
            }
            vivid.clear();
            words.clear();
            for(int i = 0; i < nextWords.size(); ++i){
                String bw = nextWords.get(i).substring(0,1);
                if (nt.indexOf(bw) != -1){
                    words.add(nextWords.get(i));
                    vivid.add(nextVivid.get(i));
                    if (!alsoCheckNT.contains(bw)) {
                        alsoCheckNT.add(bw);
                        alsoCheckWords.add(nextWords.get(i));
                        alsoCheckVivid.add(nextVivid.get(i));
                    }
                }
                if (bw.equals(cur)) cont = false;
            }
        }

        if (cont){
            System.out.println(cur+" don't have recursion");
            System.out.println();
        }
        else{
            ArrayList<ArrayList<Integer>> oldV = new ArrayList<>();
            for(int i = 0; i<vivid.size();++i){
                ArrayList<Integer> bb = new ArrayList<>(vivid.get(i));
                for(int j = 1; j<bb.size();++j){
                    if(bb.get(j)<0) bb.set(j, (bb.get(j)+1)*(-1));
                }
                vivid.set(i, bb);
            }
            for(int i = 0; i < words.size(); ++i){
                if (cur.equals(words.get(i).substring(0,1))){
                    if(!oldV.contains(vivid.get(i))){
                        oldV.add(vivid.get(i));
                        System.out.println(cur+" -> "+words.get(i));
                        ArrayList<Integer> v = new ArrayList<>(vivid.get(i));
                        System.out.print(v.get(0));
                        System.out.print(' ');
                        v.remove(0);
                        for (int k : v){
                            System.out.print(k);
                            System.out.print(' ');
                        }
                        System.out.println();
                        System.out.println();
                    }
                }
            }
        }
/////////////////////////////////////////////////////////////////////////////
        alsoCheckNT.remove(0);
        for (int c = 0; c < alsoCheckNT.size(); ++c){
            cur = alsoCheckNT.get(c);
            words.clear();
            vivid.clear();
            words.add(alsoCheckWords.get(c));
            cont = true;
            while (words.size() != 0 && cont){
                ArrayList<ArrayList<Integer>> nextVivid = new ArrayList<>();
                ArrayList<String> nextWords = new ArrayList<>();
                for (int i = 0; i < words.size(); ++i){
                    String bw = words.get(i);
                    String t = bw.substring(0, 1);
                    int rulNumb = nt.indexOf(t);
                    if(rulNumb != -1){
                        ArrayList<String> rules = p.get(rulNumb);

                        for (String s : rules){
                            ArrayList<Integer> bviv = new ArrayList<>();
                            if(!vivid.isEmpty()) bviv.addAll(vivid.get(i));
                            else {}
                            if(!s.equals(e)){
                                if (!bviv.contains(rulNumb)) {
                                    nextWords.add(s + bw.substring(1));
                                    bviv.add(rulNumb);
                                    nextVivid.add(bviv);
                                }
                            }
                            else {
                                nextWords.add(bw.substring(1));
                                bviv.add((rulNumb+1)*(-1));
                                nextVivid.add(bviv);
                            }
                        }
                    }
                }
                vivid.clear();
                words.clear();
                for(int i = 0; i < nextWords.size(); ++i){
                    if(nextWords.get(i).length() > 0){
                        String bw = nextWords.get(i).substring(0,1);
                        if (nt.indexOf(bw) != -1){
                            words.add(nextWords.get(i));
                            vivid.add(nextVivid.get(i));
                        }
                        if (bw.equals(cur)) cont = false;}
                }
            }
            if (cont){
                System.out.println(cur+" don't have recursion");
                System.out.println();
            }
            else{
                ArrayList<ArrayList<Integer>> oldViv = new ArrayList<>();
                for(int i = 0; i<vivid.size();++i){
                    ArrayList<Integer> bb = new ArrayList<>(vivid.get(i));
                    for(int j = 0; j<bb.size();++j){
                        if(bb.get(j)<0) bb.set(j, (bb.get(j)+1)*(-1));
                    }
                    vivid.set(i, bb);
                }
                for(int i = 0; i < words.size(); ++i){
                    if (cur.equals(words.get(i).substring(0,1))){
                        if (!oldViv.contains(vivid.get(i))){
                            oldViv.add(vivid.get(i));
                            System.out.println(start+" -> "+alsoCheckWords.get(c)+" -> "+words.get(i));
                            ArrayList<Integer> v = new ArrayList<>(alsoCheckVivid.get(c));
                            System.out.print(v.get(0));
                            System.out.print(' ');
                            v.remove(0);
                            for (int k : v){
                                System.out.print(k);
                                System.out.print(' ');
                            }
                            v.clear();
                            System.out.print("-> ");
                            v.addAll(vivid.get(i));
                            for (int k : v){
                                System.out.print(k);
                                System.out.print(' ');
                            }
                            System.out.println();
                            System.out.println();
                        }
                    }
                }
            }
        }
    }
}
