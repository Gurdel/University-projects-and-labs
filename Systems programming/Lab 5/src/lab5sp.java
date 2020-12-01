import java.io.Console;
import java.io.IOException;
import java.nio.charset.Charset;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class lab5sp {
    private static ArrayList<String> nt = new ArrayList<>();
    private static ArrayList<ArrayList<String>> p = new ArrayList<>();
    private static ArrayList<ArrayList<String>> followMatr = new ArrayList<>();
    private static String e;

    public static void main(String[] args) throws IOException {
        readGrammar("input1.txt");

        if(nedos()){
            System.out.println("Є НЕДОСЯЖНІ НЕТЕРМІНАЛИ");
        }
        else {
            if(neprod()){
                System.out.println("Є НЕПРОДУКТИВНІ НЕТЕРМІНАЛИ");
            }
            else {
                if(recursion()){
                    System.out.println("Є ЛІВА РЕКУРСІЯ");
                }
                else {
                    if(strong()){
                        System.out.println("СИЛЬНА");
                    }
                    else {
                        System.out.println("НЕ СИЛЬНА");
                    }
                }
            }
        }
    }

    private static boolean strong(){
        setFollowMatr();
        for(int i = 0; i < nt.size(); ++i){
            if(p.get(i).size() > 1){
                ArrayList<String> buf = new ArrayList<>(p.get(i));
                for(int k = 0; k < buf.size()-1; ++k){
                    for(int l = k+1; l < buf.size(); ++l){
                        ArrayList<String> fol = new ArrayList<>(followMatr.get(i));
                        ArrayList<String> a = new ArrayList<>();
                        ArrayList<String> b = new ArrayList<>();
                        for(String s : fol){
                            String x = buf.get(k)+s;
                            x = x.replaceAll(e, "");
                            a.add(x);
                            x = buf.get(l)+s;
                            x = x.replaceAll(e, "");
                            b.add(x);
                        }
                        ArrayList<String> firsta = new ArrayList<>();
                        ArrayList<String> firstb = new ArrayList<>();
                        for(String s : a){
                            ArrayList<String> buffirst = new ArrayList<>(first(s));
                            for(String str : buffirst){
                                if(!firsta.contains(str)){
                                    firsta.add(str);
                                }
                            }
                        }
                        for(String s : b){
                            ArrayList<String> buffirst = new ArrayList<>(first(s));
                            for(String str : buffirst){
                                if(!firstb.contains(str)){
                                    firstb.add(str);
                                }
                            }
                        }
                        for(String s : firsta){
                            if(firstb.contains(s)){
                                return false;
                            }
                        }
                    }
                }
            }
        }
        return true;
    }

    private static List<String> first(String cur){
        ArrayList<String> words = new ArrayList<>();
        ArrayList<String> res = new ArrayList<>();
        words.add(cur);
        //todo генерація порожнього слова
        while (words.size() != 0){
            ArrayList<String> nextWords = new ArrayList<>();
            for (int i = 0; i < words.size(); ++i){
                String bw = words.get(i);
                if(bw.length() != 0){//не порожнє слово
                    String t = bw.substring(0, 1);
                    bw = bw.substring(1);
                    int rulNumb = nt.indexOf(t);
                    if(rulNumb != -1){//якщо перший лівий символ є нетерміналом
                        ArrayList<String> rules = p.get(rulNumb);
                        for (String s : rules){
                            if(!s.equals(e)){
                                nextWords.add(s + bw);
                            }
                            else {
                                nextWords.add(bw);
                            }
                        }
                    }
                    else{//якщо перший лівий символ є терміналом
                        String bt = t;
                        if(bw.length() != 0) {//після лівого терміналу є символи
                            t = bw.substring(0, 1);
                            bw = bw.substring(1);
                            rulNumb = nt.indexOf(t);
                            if(rulNumb != -1){//якщо другий зліва символ є нетерміналом (перший - термінал)
                                ArrayList<String> rules = p.get(rulNumb);
                                for (String s : rules){
                                    if(!s.equals(e)){
                                        nextWords.add(bt + s + bw);
                                    }
                                    else {
                                        nextWords.add(bt + bw);
                                    }
                                }
                            }
                            else{//якщо другий зліва символ є терміналом (перший - термінал)
                                String f = bt + t;
                                if(!res.contains(f)) res.add(f);
                                //TODO порожнє слово й один термінал
                            }
                        }
                        else{//тільки лівий термінал
                            if(!res.contains(bt)) res.add(bt);
                        }
                    }
                }
                else{//порожнє слово
                    if(!res.contains(e)) res.add(e);
                }
            }
            words.clear();
            words.addAll(nextWords);
        }
        return res;
    }

    private static void setFollowMatr(){
        for(int k = 0; k < nt.size(); ++k){
            ArrayList<String> eee = new ArrayList<>();
            followMatr.add(eee);
        }
        followMatr.get(0).add(e);
        boolean changed = true;
        while (changed){
            changed = false;
            for(int k = 0; k < nt.size(); ++k){
                String n = nt.get(k);
                for(int i = 0; i < p.size(); ++i){
                    for(int j = 0; j < p.get(i).size(); ++j){
                        if(p.get(i).get(j).contains(n)){
                            String buf = p.get(i).get(j);
                            while (buf.contains(n)){
                                int index = buf.indexOf(n);
                                buf = buf.substring(index + 1);
                                if(buf.length()!=0){
                                    ArrayList<String> b = new ArrayList<>(first(buf));
                                    for (String s : b){
                                        if(!followMatr.get(k).contains(s) && !s.equals(e)){
                                            followMatr.get(k).add(s);
                                            changed = true;
                                        }
                                    }
                                    if(b.contains(e)){
                                        for(String f : followMatr.get(i)){
                                            if(!followMatr.get(k).contains(f)){
                                                followMatr.get(k).add(f);
                                                changed = true;
                                            }
                                        }
                                    }
                                }
                                else{
                                    for(String f : followMatr.get(i)){
                                        if(!followMatr.get(k).contains(f)){
                                            followMatr.get(k).add(f);
                                            changed = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private static boolean nedos(){
        String r = nt.get(0);
        for(int i = 0; i < nt.size(); ++i){
            for(int k = 0; k < p.size(); ++k){
                if(r.contains(nt.get(k))){
                    for(int l = 0; l < p.get(k).size(); ++l){
                        r += p.get(k).get(l);
                    }
                }
            }
        }
        for(int k = 0; k < nt.size(); ++k){
            if(!r.contains(nt.get(k))){
                return true;
            }
        }
        return false;
    }

    private static boolean neprod(){
        ArrayList<String> prod = new ArrayList<>();
        for(int i = 0; i < p.size(); ++i){
            for(int j = 0; j < p.get(i).size(); ++j){
                String s = p.get(i).get(j);
                boolean onlyt = true;
                while (s.length()>0){
                    String b = s.substring(0, 1);
                    s = s.substring(1);
                    if(nt.contains(b)) onlyt = false;
                }
                if(onlyt){
                    prod.add(nt.get(i));
                }
            }
        }
        for(int k = 0; k < nt.size(); ++k){
            for(int i = 0; i < p.size(); ++i){
                for(int j = 0; j < p.get(i).size(); ++j){
                    String s = p.get(i).get(j);
                    boolean onlyt = true;
                    while (s.length()>0){
                        String b = s.substring(0, 1);
                        s = s.substring(1);
                        if(nt.contains(b) && !prod.contains(b)) onlyt = false;
                    }
                    if(onlyt){
                        prod.add(nt.get(i));
                    }
                }
            }
        }
        for(int k = 0; k < nt.size(); ++k){
            if(!prod.contains(nt.get(k))){
                return true;
            }
        }
        return false;
    }

    private static boolean recursion(){
        for(String cur : nt){
            ArrayList<ArrayList<Integer>> vivid = new ArrayList<>();
            ArrayList<Integer> b = new ArrayList<>();
            b.add(-1);
            vivid.add(b);
            ArrayList<String> words = new ArrayList<>();
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
                    if(nextWords.get(i).length()!=0) {
                        String bw = nextWords.get(i).substring(0,1);
                        if (nt.indexOf(bw) != -1){
                            words.add(nextWords.get(i));
                            vivid.add(nextVivid.get(i));
                        }
                        if (bw.equals(cur)) cont = false;
                    }
                }
            }

            if (!cont){
                return true;
            }
        }
        return false;
    }

    private static void readGrammar(String fileName) throws IOException {
        List<String> linesA = Files.readAllLines(Paths.get(fileName), Charset.defaultCharset());
        e = linesA.get(0); //порожній символ
        linesA.remove(0);

        //заповнення множин нетерміналів nt і правил виведення p
        for(String s : linesA){
            String[] buf = s.split("->");
            nt.add(buf[0]);
            ArrayList<String> b = new ArrayList<>(Arrays.asList(buf[1].split(" ")));
            p.add(b);
        }
    };
}
