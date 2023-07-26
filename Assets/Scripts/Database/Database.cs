using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class Database : MonoBehaviour{

    public string NameCard = "";
    public string NameEnemies = "";
    public string NameDialogue = "";

    public Dictionary<string, CardData> Card = new Dictionary<string, CardData>(){
        {"Hache",new CardData{
        Type = "Weapon",
        Picture = "/Pictures/Hache.png",
        Description = "Longue hache qui coupe",
        NA = 10,
        HA = 50}
        }
    };

    public Dictionary<string, Dialogue> Narration = new Dictionary<string, Dialogue>()
    {

        // PART 1 POINT 1 NO CHOICES

        {"part1 dialog1 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Le vent portait les grains de sable gris aux pieds de Samten, bercé par ses méditations matinales.\nLa terre d'Hora s'éveillait autour de lui et il pouvait sentir les vibrations de la nature et de ses essences, agenouillé là, dans la cour du domaine des Monos.",
                Picture = "NarrationBG/BG"
            }
        },
        {"part1 dialog2 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Un de ses frères qui passait le balai sur les vagues formées par le sable entassé passa dans les rangs et leva une main pour leur signifier la fin de l'exercice. Chacun se redressa. Un murmure d'oiseaux s'éleva au-dessus d'eux.\nSamten observa les volatiles pendant qu'il roulait une membrane de tissu autour de ses mains.",
                Picture = "NarrationBG/BG"
            }
        },
        {"part1 dialog3 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Son ami, Anil, tapota son épaule pour le sortir de sa rêverie.",
                Picture = "NarrationBG/BG"
            }
        },
        {"part1 dialog4 choice0", new Dialogue
            {
                NameCharacter = "Anil",
                CoreText = "Allez Samten, tu iras te promener après ton entrainement, dit il en lui lancant un baton en bois blanc.",
                Picture = "NarrationBG/BG"
            }
        },

        // PART 1 POINT 2 NO CHOICES

        {"part1 dialog5 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Samten prenait une grande gorgée d'eau fraîche à la fontaine avant de franchir les portes du temple Monos. Ses pieds glissaient nonchalamment sur le sable fin et gris.\nUne Emer lumineuse s'approcha, flottant près de lui. Il tendit la main calmement pour ne pas l'effrayer. Il fit rouler la petite sphère luminescente le long de son bras et souffla pour la guider dans l'air et puis se dirigea vers sa zone d'inspection.",
                Picture = ""
            }
        },
        {"part1 dialog6 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Alors qu'il s'enfonçait dans une partie sombre de la forêt, il rencontra plus d'Emer lumineuse caractéristique de la région d'Hora. Elles illuminent le chemin d'une lumière bleue.",
                Picture = ""
            }
        },
        {"part1 dialog7 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Le chatoiement des pierres reflètent le visage de Samten qui savourait le calme de cet amas de nature qui prouvait chaque jour l'intensité de son activité.",
                Picture = ""
            }
        },
        {"part1 dialog8 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "A Hora le silence n'était pas une exception, il était la règle, la condition et le système. Dans cette région du monde la nature, les créatures qui y vivaient et les peuples qui s'y étaient installés respectaient religieusement un silence sacré. La nature particulière qui prolifère à Hora n'existait qu'à ces conditions.",
                Picture = ""
            }
        },
        {"part1 dialog9 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Chacun connaissait la règle et s'appliquait à la respecter. Les monos dont Samten était un digne représentant depuis des années étaient les gardiens de cette règle et parcouraient le territoire pour s'assurer qu'aucun trouble ne vienne perturber le territoire.",
                Picture = ""
            }
        },
        {"part1 dialog10 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Et c'est pour cette raison que Samten fut tout de suite attiré par une zone de la forêt dont les plantes semblaient éteintes, comme si le bruit en avait détruit l'essence. Il s'abaissa au plus près du sol pour ressentir les vibrations basses de cet environnement d'ordinaire immuable. ",
                Picture = ""
            }
        },
        {"part1 dialog11 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Au fil des mètres, il finit par percevoir l'écho d'un rire et de quelques babillages enfantins. Le jeune Monos se redressa et suivit la piste sur quelques mètres. C'est au coin d'un chemin de passage qu'il découvrit une petite chaussure laissée là, sur le sable. Il la souleva par un des lacets à hauteur de son visage et nota la petitesse de la pointure.",
                Picture = ""
            }
        },
        {"part1 dialog12 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = " A ce moment là le battage étranger reprit interrompu net par le son net d'un plongeon propageant le fracas dans l'eau aux alentours. Et puis, soudain, un rire. Plein et déployé. Celui d'un enfant qui barbote et qui s'acharne à éclabousser tout ce qui l'entoure.",
                Picture = ""
            }
        },
        {"part1 dialog13 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Samten vit alors les feuilles et les Emer s'éteindre peu à peu. Il courut en direction de la zone la plus affaiblie. En repoussant un pan de feuilles tombantes, il tomba sur le cours d'eau qui traversait l'endroit et le remonta peu à peu.",
                Picture = ""
            }
        },
        {"part1 dialog14 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Il découvrit tristement que ce territoire avait été malmené par l'intrus qu'il ne tarda pas à retrouver. Le petit fauteur de troubles était trempé, les cheveux dans le visage, riant aux éclats assis dans la petite rivière. Son pied nu immergé était englué de sable mouillé.",
                Picture = ""
            }
        },
        {"part1 dialog15 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Il découvrit tristement que ce territoire avait été malmené par l'intrus qu'il ne tarda pas à retrouver. Le petit fauteur de troubles était trempé, les cheveux dans le visage, riant aux éclats assis dans la petite rivière. Son pied nu immergé était englué de sable mouillé.",
                Picture = ""
            }
        },
        {"part1 dialog16 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Il mit un moment avant de remarquer Samten qui se tenait devant lui. Le jeune moine s'approcha sans bruit, sortit le petit garçon du cours d'eau. ",
                Picture = ""
            }
        },
        {"part1 dialog17 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "Ce dernier changea instantanément d'expression, très surpris de ne pas être seul. Il secoua ses cheveux noirs en gigotant de droite à gauche et se mit à hurler.",
                Picture = ""
            }
        },

        // PART 1 

        {"part1 dialog18 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "",
                Picture = ""
            }
        },
        {"part1 dialog19 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "",
                Picture = ""
            }
        },
        {"part1 dialog20 choice0", new Dialogue
            {
                NameCharacter = "",
                CoreText = "",
                Picture = ""
            }
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

//Dialogue Part
public class Dialogue
{
    public string NameCharacter;
    public string CoreText;
    public string Picture;
}

/*
    Call example:
        - Dialogue[NameDialogue].NameCharacter; calling the name with key value
        - Dialogue[NameDialogue].CoreText; calling the text with key value

    call dialogue:
        - dialog.dialogues[IDDialogue].NameCharacter;
*/
