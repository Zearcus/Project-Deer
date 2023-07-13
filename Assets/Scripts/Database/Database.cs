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

    public Dictionary<string, string> Dialogue = new Dictionary<string, string>(){
        {"part1 dialog1", "Le vent portait les grains de sable gris aux pieds de Samten, bercé par ses méditations matinales.\nLa terre d'Hora s'éveillait autour de lui et il pouvait sentir les vibrations de la nature et de ses essences, agenouillé là, dans la cour du domaine des Monos. " },
        {"part1 dialog2", "Un de ses frères qui passait le balai sur les vagues formées par le sable entassé passa dans les rangs et leva une main pour leur signifier la fin de l'exercice. Chacun se redressa.\nUn murmure d'oiseaux s'éleva au-dessus d'eux. Samten observa les volatiles pendant qu'il roulait une membrane de tissu autour de ses mains."},
        {"part1 dialog3", "Son ami, Anil, tapota son épaule pour le sortir de sa rêverie."},
        {"part1 dialog4", "Allez Samten, tu iras te promener après ton entrainement, dit il en lui lancant un baton en bois blanc."},
    
        {"part1 dialog5", "Samten prenait une grande gorgée d'eau fraîche à la fontaine avant de franchir les portes du temple Monos. Ses pieds glissaient nonchalamment sur le sable fin et gris. Une Emer lumineuse s'approcha, flottant près de lui. Il tendit la main calmement pour ne pas l'effrayer. Il fit rouler la petite sphère luminescente le long de son bras et souffla pour la guider dans l'air et puis se dirigea vers sa zone d'inspection."},
        {"part1 dialog6", "Alors qu'il s'enfonçait dans une partie sombre de la forêt, il rencontra plus d'Emer lumineuse caractéristique de la région d'Hora. Elles illuminent le chemin d'une lumière bleue. Le chatoiement des pierres reflètent le visage de Samten qui savourait le calme de cet amas de nature qui prouvait chaque jour l'intensité de son activité. A Hora le silence n'était pas une exception, il était la règle, la condition et le système."},
        {"part1 dialog7", "Dans cette région du monde la nature, les créatures qui y vivaient et les peuples qui s'y étaient installés respectaient religieusement un silence sacré. La nature particulière qui prolifère à Hora n'existait qu'à ces conditions. Chacun connaissait la règle et s'appliquait à la respecter."},
        {"part1 dialog8", "Les monos dont Samten était un digne représentant depuis des années étaient les gardiens de cette règle et parcouraient le territoire pour s'assurer qu'aucun trouble ne vienne perturber le territoire."},
        {"part1 dialog9", "Et c'est pour cette raison que Samten fut tout de suite attiré par une zone de la forêt dont les plantes semblaient éteintes, comme si le bruit en avait détruit l'essence. Il s'abaissa au plus près du sol pour ressentir les vibrations basses de cet environnement d'ordinaire immuable."}
    };

    public Dictionary<string, string> NameCharacters = new Dictionary<string, string>()
    {
        {"name1", "Santem"},
        {"name2", "Anil"},
        {"name3", "Milo"},
        {"name4", "Shinn"}
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
