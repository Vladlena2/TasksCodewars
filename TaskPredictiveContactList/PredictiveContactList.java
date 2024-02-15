package TaskPredictiveContactList;

import java.util.*;
import java.util.stream.Collectors;

public class PredictiveContactList {

    public static List<String> predict(List<String> contacts, String keystrokes) {
        Map<Integer, String> letters = new HashMap<>();
        letters.put(2, "abc");
        letters.put(3, "def");
        letters.put(4, "ghi");
        letters.put(5, "jkl");
        letters.put(6, "mno");
        letters.put(7, "pqrs");
        letters.put(8, "tuv");
        letters.put(9, "wxyz");

        List<String> newContacts;

        int indexLetter = 0;
        int symbolIteration = -1;
        do{
            try {
                int number = Integer.parseInt(String.valueOf(keystrokes.charAt(indexLetter++)));
                int finalSymbolIteration = ++symbolIteration;
                contacts = contacts.stream().filter(n -> {
                    boolean b = false;
                    for (int i = 0; i < letters.get(number).length(); i++) {
                        b = n.charAt(finalSymbolIteration) == letters.get(number).charAt(i);
                        if (b)
                            return true;
                    }
                    return false;
                }).collect(Collectors.toList());
            } catch (StringIndexOutOfBoundsException e){
                return contacts;
            }
        }
        while(indexLetter != keystrokes.length());

        // your solution
        return contacts;
    }

}
