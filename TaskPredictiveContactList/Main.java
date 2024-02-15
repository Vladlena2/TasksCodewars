package TaskPredictiveContactList;

import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<String> inputContacts = Arrays.asList(
                "jones", "thompson", "brown", "taylor",
                "bow", "smith", "cox", "timmons"
        );
        String keystrokes = "";

        List<String> outputContacts = PredictiveContactList.predict(inputContacts, keystrokes);

        System.out.println(outputContacts);
    }
}
