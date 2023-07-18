using System.Collections;
using System.Collections.Generic;
    
public class Database{
    public string NameCard = "";
    public string NameDialogue = "";
    public string NameEnemies = "";


    public Dictionary<string, CardData> Card = new Dictionary<string, CardData>(){
        {"Hache",new CardData{
        Type = "Weapon",
        Picture = "/Pictures/Hache.png",
        Description = "Longue hache qui coupe",
        NA = 10,
        HA = 50}
        }
    };

    public Dictionary<string, Dialogue> Narration = new Dictionary<string, Dialogue>(){
        {"part1 dialog1",new Dialogue{
            NameCharacter = "Test",
            CoreText = "Le vent portait les grains de sable gris aux pieds de Samten, bercé par ses méditations matinales.\nLa terre d'Hora s'éveillait autour de lui et il pouvait sentir les vibrations de la nature et de ses essences, agenouillé là, dans la cour du domaine des Monos. " }
        },
        {"part1 dialog2",new Dialogue{
            NameCharacter = "Test",
            CoreText = "Un de ses frères qui passait le balai sur les vagues formées par le sable entassé passa dans les rangs et leva une main pour leur signifier la fin de l'exercice. Chacun se redressa.\nUn murmure d'oiseaux s'éleva au-dessus d'eux. Samten observa les volatiles pendant qu'il roulait une membrane de tissu autour de ses mains." }
        },
        {"part1 dialog3",new Dialogue{
            NameCharacter = "Test",
            CoreText = "Son ami, Anil, tapota son épaule pour le sortir de sa rêverie." }
        },
        {"part1 dialog4",new Dialogue{
            NameCharacter = "Anil",
            CoreText = "Allez Samten, tu iras te promener après ton entrainement, dit il en lui lancant un baton en bois blanc."} 
        },
    };

    public Dictionary<string, EnemyData> Enemies = new Dictionary<string, EnemyData>(){

    };
}
public class CardData
{
    public string Type;

    public string Picture;

    public string Description;

    public int NA;

    public int HA;

    public int effect;
}

public class EnemyData{
    public int Hp;
    public string Picture;
    public int Attack;

}

public class Dialogue{
   public string NameCharacter;
   public string CoreText;
   public string Picture;
}

/*
    Call example:
    Dialogue[NameDialogue].NameCharacter; calling the name with key value
    Dialogue[NameDialogue].CoreText; calling the text with key value
*/
