import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;

public class FirstLab {

    public static void main(String[] args) {
        try{
            String text = Files.readString(Paths.get("inputLord.txt")); //прочитати весь файл
            System.out.println("Текст до обробки: \n");
            System.out.println(text);
            text = correctInputString(text); //видалити знаки пунктуації
            System.out.println("\nТекст після видалення знаків пунктуації: \n");
            System.out.println(text);
            ArrayList<String> res = findMaxLength(text); //знайти всі слова макс довжини
            System.out.println("\nСлова максимальної довжини без повторів: \n");
            outputResult(res); //вивести результат
        }
        catch (Exception ex){System.out.println("WARNING!!!\n "+ex.toString());};
    }

    public static String correctInputString(String in) { //видалити знаки пунктуації
        try{
            in = in.replace(".", "");
            in = in.replace("'", ""); //апостроф?
            in = in.replace("’", ""); //апостроф?
            in = in.replace("(", "");
            in = in.replace(")", "");
            in = in.replace("-", ""); //дефіс?
            in = in.replace(",", "");
            in = in.replace("\r\n", " "); //абзац
            in = in.replace(";", "");
            in = in.replace(":", "");
            in = in.replace("!", "");
            in = in.replace("?", "");
            in = in.replace(".", "");
            in = in.replace("\"", "");
            in = in.replace(" - ", " "); //тире
        }
        catch(Exception ex){System.out.println("WARNING!!!\n "+ex.toString());};

        return in;
    }

    public static ArrayList<String> findMaxLength(String s) { //знайти всі слова макс довжини
        ArrayList<String> res = new ArrayList<String>();

        try{
            String[] words = s.split(" ");

            int maxLength = words[0].length(); //макс довжина слова
            res.add(words[0]);

            for(String word : words) {
                if(word.length() > maxLength) {
                    maxLength = word.length();
                    res.clear();
                    res.add(word);
                }
                if(word.length() == maxLength) {
                    if(!res.contains(word))
                        res.add(word);
                }
            }
        }
        catch(Exception ex){System.out.println("WARNING!!!\n "+ex.toString());};

        return  res;
    }

    public static void outputResult(ArrayList<String> res){ //вивести результат
        try{
            for (String word : res){
                System.out.println(word);
            }
        }
        catch(Exception ex){System.out.println("WARNING!!!\n "+ex.toString());};
    }
}
