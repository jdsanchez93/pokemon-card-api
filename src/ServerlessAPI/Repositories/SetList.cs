using System.Text.Json;
using ServerlessAPI.Entities;

namespace ServerlessAPI.Repositories
{
    public static class SetList
    {
        static readonly string jsonString =
"""
[
    {
        "setPath": "/sets/11636/surging-sparks",
        "setCode": "SSP",
        "setId": "11636",
        "totalCards": 191,
        "cards": [
            {
                "cardId": "46339",
                "cardNumber": "001/191"
            },
            {
                "cardId": "46340",
                "cardNumber": "002/191"
            },
            {
                "cardId": "46341",
                "cardNumber": "003/191"
            },
            {
                "cardId": "46342",
                "cardNumber": "004/191"
            },
            {
                "cardId": "46343",
                "cardNumber": "005/191"
            },
            {
                "cardId": "46344",
                "cardNumber": "006/191"
            },
            {
                "cardId": "46345",
                "cardNumber": "007/191"
            },
            {
                "cardId": "46346",
                "cardNumber": "008/191"
            },
            {
                "cardId": "46347",
                "cardNumber": "009/191"
            },
            {
                "cardId": "46348",
                "cardNumber": "010/191"
            },
            {
                "cardId": "46349",
                "cardNumber": "011/191"
            },
            {
                "cardId": "46350",
                "cardNumber": "012/191"
            },
            {
                "cardId": "46351",
                "cardNumber": "013/191"
            },
            {
                "cardId": "46352",
                "cardNumber": "014/191"
            },
            {
                "cardId": "46353",
                "cardNumber": "015/191"
            },
            {
                "cardId": "46354",
                "cardNumber": "016/191"
            },
            {
                "cardId": "46355",
                "cardNumber": "017/191"
            },
            {
                "cardId": "46356",
                "cardNumber": "018/191"
            },
            {
                "cardId": "46357",
                "cardNumber": "019/191"
            },
            {
                "cardId": "46358",
                "cardNumber": "020/191"
            },
            {
                "cardId": "46359",
                "cardNumber": "021/191"
            },
            {
                "cardId": "46360",
                "cardNumber": "022/191"
            },
            {
                "cardId": "46361",
                "cardNumber": "023/191"
            },
            {
                "cardId": "46362",
                "cardNumber": "024/191"
            },
            {
                "cardId": "46363",
                "cardNumber": "025/191"
            },
            {
                "cardId": "46364",
                "cardNumber": "026/191"
            },
            {
                "cardId": "46365",
                "cardNumber": "027/191"
            },
            {
                "cardId": "46366",
                "cardNumber": "028/191"
            },
            {
                "cardId": "46367",
                "cardNumber": "029/191"
            },
            {
                "cardId": "46368",
                "cardNumber": "030/191"
            },
            {
                "cardId": "46369",
                "cardNumber": "031/191"
            },
            {
                "cardId": "46370",
                "cardNumber": "032/191"
            },
            {
                "cardId": "46371",
                "cardNumber": "033/191"
            },
            {
                "cardId": "46372",
                "cardNumber": "034/191"
            },
            {
                "cardId": "46373",
                "cardNumber": "035/191"
            },
            {
                "cardId": "46374",
                "cardNumber": "036/191"
            },
            {
                "cardId": "46375",
                "cardNumber": "037/191"
            },
            {
                "cardId": "46376",
                "cardNumber": "038/191"
            },
            {
                "cardId": "46377",
                "cardNumber": "039/191"
            },
            {
                "cardId": "46378",
                "cardNumber": "040/191"
            },
            {
                "cardId": "46379",
                "cardNumber": "041/191"
            },
            {
                "cardId": "46380",
                "cardNumber": "042/191"
            },
            {
                "cardId": "46381",
                "cardNumber": "043/191"
            },
            {
                "cardId": "46382",
                "cardNumber": "044/191"
            },
            {
                "cardId": "46383",
                "cardNumber": "045/191"
            },
            {
                "cardId": "46384",
                "cardNumber": "046/191"
            },
            {
                "cardId": "46385",
                "cardNumber": "047/191"
            },
            {
                "cardId": "46386",
                "cardNumber": "048/191"
            },
            {
                "cardId": "46387",
                "cardNumber": "049/191"
            },
            {
                "cardId": "46388",
                "cardNumber": "050/191"
            },
            {
                "cardId": "46389",
                "cardNumber": "051/191"
            },
            {
                "cardId": "46390",
                "cardNumber": "052/191"
            },
            {
                "cardId": "46391",
                "cardNumber": "053/191"
            },
            {
                "cardId": "46392",
                "cardNumber": "054/191"
            },
            {
                "cardId": "46393",
                "cardNumber": "055/191"
            },
            {
                "cardId": "46394",
                "cardNumber": "056/191"
            },
            {
                "cardId": "46395",
                "cardNumber": "057/191"
            },
            {
                "cardId": "46396",
                "cardNumber": "058/191"
            },
            {
                "cardId": "46397",
                "cardNumber": "059/191"
            },
            {
                "cardId": "46398",
                "cardNumber": "060/191"
            },
            {
                "cardId": "46399",
                "cardNumber": "061/191"
            },
            {
                "cardId": "46400",
                "cardNumber": "062/191"
            },
            {
                "cardId": "46401",
                "cardNumber": "063/191"
            },
            {
                "cardId": "46402",
                "cardNumber": "064/191"
            },
            {
                "cardId": "46403",
                "cardNumber": "065/191"
            },
            {
                "cardId": "46404",
                "cardNumber": "066/191"
            },
            {
                "cardId": "46405",
                "cardNumber": "067/191"
            },
            {
                "cardId": "46406",
                "cardNumber": "068/191"
            },
            {
                "cardId": "46407",
                "cardNumber": "069/191"
            },
            {
                "cardId": "46408",
                "cardNumber": "070/191"
            },
            {
                "cardId": "46409",
                "cardNumber": "071/191"
            },
            {
                "cardId": "46410",
                "cardNumber": "072/191"
            },
            {
                "cardId": "46411",
                "cardNumber": "073/191"
            },
            {
                "cardId": "46412",
                "cardNumber": "074/191"
            },
            {
                "cardId": "46413",
                "cardNumber": "075/191"
            },
            {
                "cardId": "46414",
                "cardNumber": "076/191"
            },
            {
                "cardId": "46415",
                "cardNumber": "077/191"
            },
            {
                "cardId": "46416",
                "cardNumber": "078/191"
            },
            {
                "cardId": "46417",
                "cardNumber": "079/191"
            },
            {
                "cardId": "46418",
                "cardNumber": "080/191"
            },
            {
                "cardId": "46419",
                "cardNumber": "081/191"
            },
            {
                "cardId": "46420",
                "cardNumber": "082/191"
            },
            {
                "cardId": "46421",
                "cardNumber": "083/191"
            },
            {
                "cardId": "46422",
                "cardNumber": "084/191"
            },
            {
                "cardId": "46423",
                "cardNumber": "085/191"
            },
            {
                "cardId": "46424",
                "cardNumber": "086/191"
            },
            {
                "cardId": "46425",
                "cardNumber": "087/191"
            },
            {
                "cardId": "46426",
                "cardNumber": "088/191"
            },
            {
                "cardId": "46427",
                "cardNumber": "089/191"
            },
            {
                "cardId": "46428",
                "cardNumber": "090/191"
            },
            {
                "cardId": "46429",
                "cardNumber": "091/191"
            },
            {
                "cardId": "46430",
                "cardNumber": "092/191"
            },
            {
                "cardId": "46431",
                "cardNumber": "093/191"
            },
            {
                "cardId": "46432",
                "cardNumber": "094/191"
            },
            {
                "cardId": "46433",
                "cardNumber": "095/191"
            },
            {
                "cardId": "46434",
                "cardNumber": "096/191"
            },
            {
                "cardId": "46435",
                "cardNumber": "097/191"
            },
            {
                "cardId": "46436",
                "cardNumber": "098/191"
            },
            {
                "cardId": "46437",
                "cardNumber": "099/191"
            },
            {
                "cardId": "46438",
                "cardNumber": "100/191"
            },
            {
                "cardId": "46439",
                "cardNumber": "101/191"
            },
            {
                "cardId": "46440",
                "cardNumber": "102/191"
            },
            {
                "cardId": "46441",
                "cardNumber": "103/191"
            },
            {
                "cardId": "46442",
                "cardNumber": "104/191"
            },
            {
                "cardId": "46443",
                "cardNumber": "105/191"
            },
            {
                "cardId": "46444",
                "cardNumber": "106/191"
            },
            {
                "cardId": "46445",
                "cardNumber": "107/191"
            },
            {
                "cardId": "46446",
                "cardNumber": "108/191"
            },
            {
                "cardId": "46447",
                "cardNumber": "109/191"
            },
            {
                "cardId": "46448",
                "cardNumber": "110/191"
            },
            {
                "cardId": "46449",
                "cardNumber": "111/191"
            },
            {
                "cardId": "46450",
                "cardNumber": "112/191"
            },
            {
                "cardId": "46451",
                "cardNumber": "113/191"
            },
            {
                "cardId": "46452",
                "cardNumber": "114/191"
            },
            {
                "cardId": "46453",
                "cardNumber": "115/191"
            },
            {
                "cardId": "46454",
                "cardNumber": "116/191"
            },
            {
                "cardId": "46455",
                "cardNumber": "117/191"
            },
            {
                "cardId": "46456",
                "cardNumber": "118/191"
            },
            {
                "cardId": "46457",
                "cardNumber": "119/191"
            },
            {
                "cardId": "46458",
                "cardNumber": "120/191"
            },
            {
                "cardId": "46459",
                "cardNumber": "121/191"
            },
            {
                "cardId": "46460",
                "cardNumber": "122/191"
            },
            {
                "cardId": "46461",
                "cardNumber": "123/191"
            },
            {
                "cardId": "46462",
                "cardNumber": "124/191"
            },
            {
                "cardId": "46463",
                "cardNumber": "125/191"
            },
            {
                "cardId": "46464",
                "cardNumber": "126/191"
            },
            {
                "cardId": "46465",
                "cardNumber": "127/191"
            },
            {
                "cardId": "46466",
                "cardNumber": "128/191"
            },
            {
                "cardId": "46467",
                "cardNumber": "129/191"
            },
            {
                "cardId": "46468",
                "cardNumber": "130/191"
            },
            {
                "cardId": "46469",
                "cardNumber": "131/191"
            },
            {
                "cardId": "46470",
                "cardNumber": "132/191"
            },
            {
                "cardId": "46471",
                "cardNumber": "133/191"
            },
            {
                "cardId": "46472",
                "cardNumber": "134/191"
            },
            {
                "cardId": "46473",
                "cardNumber": "135/191"
            },
            {
                "cardId": "46474",
                "cardNumber": "136/191"
            },
            {
                "cardId": "46475",
                "cardNumber": "137/191"
            },
            {
                "cardId": "46476",
                "cardNumber": "138/191"
            },
            {
                "cardId": "46477",
                "cardNumber": "139/191"
            },
            {
                "cardId": "46478",
                "cardNumber": "140/191"
            },
            {
                "cardId": "46479",
                "cardNumber": "141/191"
            },
            {
                "cardId": "46480",
                "cardNumber": "142/191"
            },
            {
                "cardId": "46481",
                "cardNumber": "143/191"
            },
            {
                "cardId": "46482",
                "cardNumber": "144/191"
            },
            {
                "cardId": "46483",
                "cardNumber": "145/191"
            },
            {
                "cardId": "46484",
                "cardNumber": "146/191"
            },
            {
                "cardId": "46485",
                "cardNumber": "147/191"
            },
            {
                "cardId": "46486",
                "cardNumber": "148/191"
            },
            {
                "cardId": "46487",
                "cardNumber": "149/191"
            },
            {
                "cardId": "46488",
                "cardNumber": "150/191"
            },
            {
                "cardId": "46489",
                "cardNumber": "151/191"
            },
            {
                "cardId": "46490",
                "cardNumber": "152/191"
            },
            {
                "cardId": "46491",
                "cardNumber": "153/191"
            },
            {
                "cardId": "46492",
                "cardNumber": "154/191"
            },
            {
                "cardId": "46493",
                "cardNumber": "155/191"
            },
            {
                "cardId": "46494",
                "cardNumber": "156/191"
            },
            {
                "cardId": "46495",
                "cardNumber": "157/191"
            },
            {
                "cardId": "46496",
                "cardNumber": "158/191"
            },
            {
                "cardId": "46497",
                "cardNumber": "159/191"
            },
            {
                "cardId": "46498",
                "cardNumber": "160/191"
            },
            {
                "cardId": "46499",
                "cardNumber": "161/191"
            },
            {
                "cardId": "46500",
                "cardNumber": "162/191"
            },
            {
                "cardId": "46501",
                "cardNumber": "163/191"
            },
            {
                "cardId": "46502",
                "cardNumber": "164/191"
            },
            {
                "cardId": "46503",
                "cardNumber": "165/191"
            },
            {
                "cardId": "46504",
                "cardNumber": "166/191"
            },
            {
                "cardId": "46505",
                "cardNumber": "167/191"
            },
            {
                "cardId": "46506",
                "cardNumber": "168/191"
            },
            {
                "cardId": "46507",
                "cardNumber": "169/191"
            },
            {
                "cardId": "46508",
                "cardNumber": "170/191"
            },
            {
                "cardId": "46509",
                "cardNumber": "171/191"
            },
            {
                "cardId": "46510",
                "cardNumber": "172/191"
            },
            {
                "cardId": "46511",
                "cardNumber": "173/191"
            },
            {
                "cardId": "46512",
                "cardNumber": "174/191"
            },
            {
                "cardId": "46513",
                "cardNumber": "175/191"
            },
            {
                "cardId": "46514",
                "cardNumber": "176/191"
            },
            {
                "cardId": "46515",
                "cardNumber": "177/191"
            },
            {
                "cardId": "46516",
                "cardNumber": "178/191"
            },
            {
                "cardId": "46517",
                "cardNumber": "179/191"
            },
            {
                "cardId": "46518",
                "cardNumber": "180/191"
            },
            {
                "cardId": "46519",
                "cardNumber": "181/191"
            },
            {
                "cardId": "46520",
                "cardNumber": "182/191"
            },
            {
                "cardId": "46521",
                "cardNumber": "183/191"
            },
            {
                "cardId": "46522",
                "cardNumber": "184/191"
            },
            {
                "cardId": "46523",
                "cardNumber": "185/191"
            },
            {
                "cardId": "46524",
                "cardNumber": "186/191"
            },
            {
                "cardId": "46525",
                "cardNumber": "187/191"
            },
            {
                "cardId": "46526",
                "cardNumber": "188/191"
            },
            {
                "cardId": "46527",
                "cardNumber": "189/191"
            },
            {
                "cardId": "46528",
                "cardNumber": "190/191"
            },
            {
                "cardId": "46529",
                "cardNumber": "191/191"
            },
            {
                "cardId": "46530",
                "cardNumber": "192/191"
            },
            {
                "cardId": "46531",
                "cardNumber": "193/191"
            },
            {
                "cardId": "46532",
                "cardNumber": "194/191"
            },
            {
                "cardId": "46533",
                "cardNumber": "195/191"
            },
            {
                "cardId": "46534",
                "cardNumber": "196/191"
            },
            {
                "cardId": "46535",
                "cardNumber": "197/191"
            },
            {
                "cardId": "46536",
                "cardNumber": "198/191"
            },
            {
                "cardId": "46537",
                "cardNumber": "199/191"
            },
            {
                "cardId": "46538",
                "cardNumber": "200/191"
            },
            {
                "cardId": "46539",
                "cardNumber": "201/191"
            },
            {
                "cardId": "46540",
                "cardNumber": "202/191"
            },
            {
                "cardId": "46541",
                "cardNumber": "203/191"
            },
            {
                "cardId": "46542",
                "cardNumber": "204/191"
            },
            {
                "cardId": "46543",
                "cardNumber": "205/191"
            },
            {
                "cardId": "46544",
                "cardNumber": "206/191"
            },
            {
                "cardId": "46545",
                "cardNumber": "207/191"
            },
            {
                "cardId": "46546",
                "cardNumber": "208/191"
            },
            {
                "cardId": "46547",
                "cardNumber": "209/191"
            },
            {
                "cardId": "46548",
                "cardNumber": "210/191"
            },
            {
                "cardId": "46549",
                "cardNumber": "211/191"
            },
            {
                "cardId": "46550",
                "cardNumber": "212/191"
            },
            {
                "cardId": "46551",
                "cardNumber": "213/191"
            },
            {
                "cardId": "46552",
                "cardNumber": "214/191"
            },
            {
                "cardId": "46553",
                "cardNumber": "215/191"
            },
            {
                "cardId": "46554",
                "cardNumber": "216/191"
            },
            {
                "cardId": "46555",
                "cardNumber": "217/191"
            },
            {
                "cardId": "46556",
                "cardNumber": "218/191"
            },
            {
                "cardId": "46557",
                "cardNumber": "219/191"
            },
            {
                "cardId": "46558",
                "cardNumber": "220/191"
            },
            {
                "cardId": "46559",
                "cardNumber": "221/191"
            },
            {
                "cardId": "46560",
                "cardNumber": "222/191"
            },
            {
                "cardId": "46561",
                "cardNumber": "223/191"
            },
            {
                "cardId": "46562",
                "cardNumber": "224/191"
            },
            {
                "cardId": "46563",
                "cardNumber": "225/191"
            },
            {
                "cardId": "46564",
                "cardNumber": "226/191"
            },
            {
                "cardId": "46565",
                "cardNumber": "227/191"
            },
            {
                "cardId": "46566",
                "cardNumber": "228/191"
            },
            {
                "cardId": "46567",
                "cardNumber": "229/191"
            },
            {
                "cardId": "46568",
                "cardNumber": "230/191"
            },
            {
                "cardId": "46569",
                "cardNumber": "231/191"
            },
            {
                "cardId": "46570",
                "cardNumber": "232/191"
            },
            {
                "cardId": "46571",
                "cardNumber": "233/191"
            },
            {
                "cardId": "46572",
                "cardNumber": "234/191"
            },
            {
                "cardId": "46573",
                "cardNumber": "235/191"
            },
            {
                "cardId": "46574",
                "cardNumber": "236/191"
            },
            {
                "cardId": "46575",
                "cardNumber": "237/191"
            },
            {
                "cardId": "46576",
                "cardNumber": "238/191"
            },
            {
                "cardId": "46577",
                "cardNumber": "239/191"
            },
            {
                "cardId": "46578",
                "cardNumber": "240/191"
            },
            {
                "cardId": "46579",
                "cardNumber": "241/191"
            },
            {
                "cardId": "46580",
                "cardNumber": "242/191"
            },
            {
                "cardId": "46581",
                "cardNumber": "243/191"
            },
            {
                "cardId": "46582",
                "cardNumber": "244/191"
            },
            {
                "cardId": "46583",
                "cardNumber": "245/191"
            },
            {
                "cardId": "46584",
                "cardNumber": "246/191"
            },
            {
                "cardId": "46585",
                "cardNumber": "247/191"
            },
            {
                "cardId": "46586",
                "cardNumber": "248/191"
            },
            {
                "cardId": "46587",
                "cardNumber": "249/191"
            },
            {
                "cardId": "46588",
                "cardNumber": "250/191"
            },
            {
                "cardId": "46589",
                "cardNumber": "251/191"
            },
            {
                "cardId": "46590",
                "cardNumber": "252/191"
            }
        ]
    },
    {
        "setPath": "/sets/11632/stellar-crown",
        "setCode": "SCR",
        "setId": "11632",
        "totalCards": 142,
        "cards": [
            {
                "cardId": "45986",
                "cardNumber": "001/142"
            },
            {
                "cardId": "45987",
                "cardNumber": "002/142"
            },
            {
                "cardId": "45988",
                "cardNumber": "003/142"
            },
            {
                "cardId": "45989",
                "cardNumber": "004/142"
            },
            {
                "cardId": "45990",
                "cardNumber": "005/142"
            },
            {
                "cardId": "45991",
                "cardNumber": "006/142"
            },
            {
                "cardId": "45992",
                "cardNumber": "007/142"
            },
            {
                "cardId": "45993",
                "cardNumber": "008/142"
            },
            {
                "cardId": "45994",
                "cardNumber": "009/142"
            },
            {
                "cardId": "45995",
                "cardNumber": "010/142"
            },
            {
                "cardId": "45996",
                "cardNumber": "011/142"
            },
            {
                "cardId": "45997",
                "cardNumber": "012/142"
            },
            {
                "cardId": "45998",
                "cardNumber": "013/142"
            },
            {
                "cardId": "45999",
                "cardNumber": "014/142"
            },
            {
                "cardId": "46000",
                "cardNumber": "015/142"
            },
            {
                "cardId": "46001",
                "cardNumber": "016/142"
            },
            {
                "cardId": "46002",
                "cardNumber": "017/142"
            },
            {
                "cardId": "46003",
                "cardNumber": "018/142"
            },
            {
                "cardId": "46004",
                "cardNumber": "019/142"
            },
            {
                "cardId": "46005",
                "cardNumber": "020/142"
            },
            {
                "cardId": "46006",
                "cardNumber": "021/142"
            },
            {
                "cardId": "46007",
                "cardNumber": "022/142"
            },
            {
                "cardId": "46008",
                "cardNumber": "023/142"
            },
            {
                "cardId": "46009",
                "cardNumber": "024/142"
            },
            {
                "cardId": "46010",
                "cardNumber": "025/142"
            },
            {
                "cardId": "46011",
                "cardNumber": "026/142"
            },
            {
                "cardId": "46012",
                "cardNumber": "027/142"
            },
            {
                "cardId": "46013",
                "cardNumber": "028/142"
            },
            {
                "cardId": "46014",
                "cardNumber": "029/142"
            },
            {
                "cardId": "46015",
                "cardNumber": "030/142"
            },
            {
                "cardId": "46016",
                "cardNumber": "031/142"
            },
            {
                "cardId": "46017",
                "cardNumber": "032/142"
            },
            {
                "cardId": "46018",
                "cardNumber": "033/142"
            },
            {
                "cardId": "46019",
                "cardNumber": "034/142"
            },
            {
                "cardId": "46020",
                "cardNumber": "035/142"
            },
            {
                "cardId": "46021",
                "cardNumber": "036/142"
            },
            {
                "cardId": "46022",
                "cardNumber": "037/142"
            },
            {
                "cardId": "46023",
                "cardNumber": "038/142"
            },
            {
                "cardId": "46024",
                "cardNumber": "039/142"
            },
            {
                "cardId": "46025",
                "cardNumber": "040/142"
            },
            {
                "cardId": "46026",
                "cardNumber": "041/142"
            },
            {
                "cardId": "46027",
                "cardNumber": "042/142"
            },
            {
                "cardId": "46028",
                "cardNumber": "043/142"
            },
            {
                "cardId": "46029",
                "cardNumber": "044/142"
            },
            {
                "cardId": "46030",
                "cardNumber": "045/142"
            },
            {
                "cardId": "46031",
                "cardNumber": "046/142"
            },
            {
                "cardId": "46032",
                "cardNumber": "047/142"
            },
            {
                "cardId": "46033",
                "cardNumber": "048/142"
            },
            {
                "cardId": "46034",
                "cardNumber": "049/142"
            },
            {
                "cardId": "46035",
                "cardNumber": "050/142"
            },
            {
                "cardId": "46036",
                "cardNumber": "051/142"
            },
            {
                "cardId": "46037",
                "cardNumber": "052/142"
            },
            {
                "cardId": "46038",
                "cardNumber": "053/142"
            },
            {
                "cardId": "46039",
                "cardNumber": "054/142"
            },
            {
                "cardId": "46040",
                "cardNumber": "055/142"
            },
            {
                "cardId": "46041",
                "cardNumber": "056/142"
            },
            {
                "cardId": "46042",
                "cardNumber": "057/142"
            },
            {
                "cardId": "46043",
                "cardNumber": "058/142"
            },
            {
                "cardId": "46044",
                "cardNumber": "059/142"
            },
            {
                "cardId": "46045",
                "cardNumber": "060/142"
            },
            {
                "cardId": "46046",
                "cardNumber": "061/142"
            },
            {
                "cardId": "46047",
                "cardNumber": "062/142"
            },
            {
                "cardId": "46048",
                "cardNumber": "063/142"
            },
            {
                "cardId": "46049",
                "cardNumber": "064/142"
            },
            {
                "cardId": "46050",
                "cardNumber": "065/142"
            },
            {
                "cardId": "46051",
                "cardNumber": "066/142"
            },
            {
                "cardId": "46052",
                "cardNumber": "067/142"
            },
            {
                "cardId": "46053",
                "cardNumber": "068/142"
            },
            {
                "cardId": "46054",
                "cardNumber": "069/142"
            },
            {
                "cardId": "46055",
                "cardNumber": "070/142"
            },
            {
                "cardId": "46056",
                "cardNumber": "071/142"
            },
            {
                "cardId": "46057",
                "cardNumber": "072/142"
            },
            {
                "cardId": "46058",
                "cardNumber": "073/142"
            },
            {
                "cardId": "46059",
                "cardNumber": "074/142"
            },
            {
                "cardId": "46060",
                "cardNumber": "075/142"
            },
            {
                "cardId": "46061",
                "cardNumber": "076/142"
            },
            {
                "cardId": "46062",
                "cardNumber": "077/142"
            },
            {
                "cardId": "46063",
                "cardNumber": "078/142"
            },
            {
                "cardId": "46064",
                "cardNumber": "079/142"
            },
            {
                "cardId": "46065",
                "cardNumber": "080/142"
            },
            {
                "cardId": "46066",
                "cardNumber": "081/142"
            },
            {
                "cardId": "46067",
                "cardNumber": "082/142"
            },
            {
                "cardId": "46068",
                "cardNumber": "083/142"
            },
            {
                "cardId": "46069",
                "cardNumber": "084/142"
            },
            {
                "cardId": "46070",
                "cardNumber": "085/142"
            },
            {
                "cardId": "46071",
                "cardNumber": "086/142"
            },
            {
                "cardId": "46072",
                "cardNumber": "087/142"
            },
            {
                "cardId": "46073",
                "cardNumber": "088/142"
            },
            {
                "cardId": "46074",
                "cardNumber": "089/142"
            },
            {
                "cardId": "46075",
                "cardNumber": "090/142"
            },
            {
                "cardId": "46076",
                "cardNumber": "091/142"
            },
            {
                "cardId": "46077",
                "cardNumber": "092/142"
            },
            {
                "cardId": "46078",
                "cardNumber": "093/142"
            },
            {
                "cardId": "46079",
                "cardNumber": "094/142"
            },
            {
                "cardId": "46080",
                "cardNumber": "095/142"
            },
            {
                "cardId": "46081",
                "cardNumber": "096/142"
            },
            {
                "cardId": "46082",
                "cardNumber": "097/142"
            },
            {
                "cardId": "46083",
                "cardNumber": "098/142"
            },
            {
                "cardId": "46084",
                "cardNumber": "099/142"
            },
            {
                "cardId": "46085",
                "cardNumber": "100/142"
            },
            {
                "cardId": "46086",
                "cardNumber": "101/142"
            },
            {
                "cardId": "46087",
                "cardNumber": "102/142"
            },
            {
                "cardId": "46088",
                "cardNumber": "103/142"
            },
            {
                "cardId": "46089",
                "cardNumber": "104/142"
            },
            {
                "cardId": "46090",
                "cardNumber": "105/142"
            },
            {
                "cardId": "46091",
                "cardNumber": "106/142"
            },
            {
                "cardId": "46092",
                "cardNumber": "107/142"
            },
            {
                "cardId": "46093",
                "cardNumber": "108/142"
            },
            {
                "cardId": "46094",
                "cardNumber": "109/142"
            },
            {
                "cardId": "46095",
                "cardNumber": "110/142"
            },
            {
                "cardId": "46096",
                "cardNumber": "111/142"
            },
            {
                "cardId": "46097",
                "cardNumber": "112/142"
            },
            {
                "cardId": "46098",
                "cardNumber": "113/142"
            },
            {
                "cardId": "46099",
                "cardNumber": "114/142"
            },
            {
                "cardId": "46100",
                "cardNumber": "115/142"
            },
            {
                "cardId": "46101",
                "cardNumber": "116/142"
            },
            {
                "cardId": "46102",
                "cardNumber": "117/142"
            },
            {
                "cardId": "46103",
                "cardNumber": "118/142"
            },
            {
                "cardId": "46104",
                "cardNumber": "119/142"
            },
            {
                "cardId": "46105",
                "cardNumber": "120/142"
            },
            {
                "cardId": "46106",
                "cardNumber": "121/142"
            },
            {
                "cardId": "46107",
                "cardNumber": "122/142"
            },
            {
                "cardId": "46108",
                "cardNumber": "123/142"
            },
            {
                "cardId": "46109",
                "cardNumber": "124/142"
            },
            {
                "cardId": "46110",
                "cardNumber": "125/142"
            },
            {
                "cardId": "46111",
                "cardNumber": "126/142"
            },
            {
                "cardId": "46112",
                "cardNumber": "127/142"
            },
            {
                "cardId": "46113",
                "cardNumber": "128/142"
            },
            {
                "cardId": "46114",
                "cardNumber": "129/142"
            },
            {
                "cardId": "46115",
                "cardNumber": "130/142"
            },
            {
                "cardId": "46116",
                "cardNumber": "131/142"
            },
            {
                "cardId": "46117",
                "cardNumber": "132/142"
            },
            {
                "cardId": "46118",
                "cardNumber": "133/142"
            },
            {
                "cardId": "46119",
                "cardNumber": "134/142"
            },
            {
                "cardId": "46120",
                "cardNumber": "135/142"
            },
            {
                "cardId": "46121",
                "cardNumber": "136/142"
            },
            {
                "cardId": "46122",
                "cardNumber": "137/142"
            },
            {
                "cardId": "46123",
                "cardNumber": "138/142"
            },
            {
                "cardId": "46124",
                "cardNumber": "139/142"
            },
            {
                "cardId": "46125",
                "cardNumber": "140/142"
            },
            {
                "cardId": "46126",
                "cardNumber": "141/142"
            },
            {
                "cardId": "46127",
                "cardNumber": "142/142"
            },
            {
                "cardId": "46128",
                "cardNumber": "143/142"
            },
            {
                "cardId": "46129",
                "cardNumber": "144/142"
            },
            {
                "cardId": "46130",
                "cardNumber": "145/142"
            },
            {
                "cardId": "46131",
                "cardNumber": "146/142"
            },
            {
                "cardId": "46132",
                "cardNumber": "147/142"
            },
            {
                "cardId": "46133",
                "cardNumber": "148/142"
            },
            {
                "cardId": "46134",
                "cardNumber": "149/142"
            },
            {
                "cardId": "46135",
                "cardNumber": "150/142"
            },
            {
                "cardId": "46136",
                "cardNumber": "151/142"
            },
            {
                "cardId": "46137",
                "cardNumber": "152/142"
            },
            {
                "cardId": "46138",
                "cardNumber": "153/142"
            },
            {
                "cardId": "46139",
                "cardNumber": "154/142"
            },
            {
                "cardId": "46140",
                "cardNumber": "155/142"
            },
            {
                "cardId": "46141",
                "cardNumber": "156/142"
            },
            {
                "cardId": "46142",
                "cardNumber": "157/142"
            },
            {
                "cardId": "46143",
                "cardNumber": "158/142"
            },
            {
                "cardId": "46144",
                "cardNumber": "159/142"
            },
            {
                "cardId": "46145",
                "cardNumber": "160/142"
            },
            {
                "cardId": "46146",
                "cardNumber": "161/142"
            },
            {
                "cardId": "46147",
                "cardNumber": "162/142"
            },
            {
                "cardId": "46148",
                "cardNumber": "163/142"
            },
            {
                "cardId": "46149",
                "cardNumber": "164/142"
            },
            {
                "cardId": "46150",
                "cardNumber": "165/142"
            },
            {
                "cardId": "46151",
                "cardNumber": "166/142"
            },
            {
                "cardId": "46152",
                "cardNumber": "167/142"
            },
            {
                "cardId": "46153",
                "cardNumber": "168/142"
            },
            {
                "cardId": "46154",
                "cardNumber": "169/142"
            },
            {
                "cardId": "46155",
                "cardNumber": "170/142"
            },
            {
                "cardId": "46156",
                "cardNumber": "171/142"
            },
            {
                "cardId": "46157",
                "cardNumber": "172/142"
            },
            {
                "cardId": "46158",
                "cardNumber": "173/142"
            },
            {
                "cardId": "46159",
                "cardNumber": "174/142"
            },
            {
                "cardId": "46160",
                "cardNumber": "175/142"
            }
        ]
    },
    {
        "setPath": "/sets/11631/shrouded-fable",
        "setCode": "SFA",
        "setId": "11631",
        "totalCards": 64,
        "cards": [
            {
                "cardId": "45651",
                "cardNumber": "001/064"
            },
            {
                "cardId": "45652",
                "cardNumber": "002/064"
            },
            {
                "cardId": "45653",
                "cardNumber": "003/064"
            },
            {
                "cardId": "45654",
                "cardNumber": "004/064"
            },
            {
                "cardId": "45655",
                "cardNumber": "005/064"
            },
            {
                "cardId": "45656",
                "cardNumber": "006/064"
            },
            {
                "cardId": "45657",
                "cardNumber": "007/064"
            },
            {
                "cardId": "45658",
                "cardNumber": "008/064"
            },
            {
                "cardId": "45659",
                "cardNumber": "009/064"
            },
            {
                "cardId": "45660",
                "cardNumber": "010/064"
            },
            {
                "cardId": "45661",
                "cardNumber": "011/064"
            },
            {
                "cardId": "45662",
                "cardNumber": "012/064"
            },
            {
                "cardId": "45663",
                "cardNumber": "013/064"
            },
            {
                "cardId": "45664",
                "cardNumber": "014/064"
            },
            {
                "cardId": "45665",
                "cardNumber": "015/064"
            },
            {
                "cardId": "45666",
                "cardNumber": "016/064"
            },
            {
                "cardId": "45667",
                "cardNumber": "017/064"
            },
            {
                "cardId": "45668",
                "cardNumber": "018/064"
            },
            {
                "cardId": "45669",
                "cardNumber": "019/064"
            },
            {
                "cardId": "45670",
                "cardNumber": "020/064"
            },
            {
                "cardId": "45671",
                "cardNumber": "021/064"
            },
            {
                "cardId": "45672",
                "cardNumber": "022/064"
            },
            {
                "cardId": "45673",
                "cardNumber": "023/064"
            },
            {
                "cardId": "45674",
                "cardNumber": "024/064"
            },
            {
                "cardId": "45675",
                "cardNumber": "025/064"
            },
            {
                "cardId": "45676",
                "cardNumber": "026/064"
            },
            {
                "cardId": "45677",
                "cardNumber": "027/064"
            },
            {
                "cardId": "45678",
                "cardNumber": "028/064"
            },
            {
                "cardId": "45679",
                "cardNumber": "029/064"
            },
            {
                "cardId": "45680",
                "cardNumber": "030/064"
            },
            {
                "cardId": "45681",
                "cardNumber": "031/064"
            },
            {
                "cardId": "45682",
                "cardNumber": "032/064"
            },
            {
                "cardId": "45683",
                "cardNumber": "033/064"
            },
            {
                "cardId": "45684",
                "cardNumber": "034/064"
            },
            {
                "cardId": "45685",
                "cardNumber": "035/064"
            },
            {
                "cardId": "45686",
                "cardNumber": "036/064"
            },
            {
                "cardId": "45687",
                "cardNumber": "037/064"
            },
            {
                "cardId": "45688",
                "cardNumber": "038/064"
            },
            {
                "cardId": "45689",
                "cardNumber": "039/064"
            },
            {
                "cardId": "45690",
                "cardNumber": "040/064"
            },
            {
                "cardId": "45691",
                "cardNumber": "041/064"
            },
            {
                "cardId": "45692",
                "cardNumber": "042/064"
            },
            {
                "cardId": "45693",
                "cardNumber": "043/064"
            },
            {
                "cardId": "45694",
                "cardNumber": "044/064"
            },
            {
                "cardId": "45695",
                "cardNumber": "045/064"
            },
            {
                "cardId": "45696",
                "cardNumber": "046/064"
            },
            {
                "cardId": "45697",
                "cardNumber": "047/064"
            },
            {
                "cardId": "45698",
                "cardNumber": "048/064"
            },
            {
                "cardId": "45699",
                "cardNumber": "049/064"
            },
            {
                "cardId": "45700",
                "cardNumber": "050/064"
            },
            {
                "cardId": "45701",
                "cardNumber": "051/064"
            },
            {
                "cardId": "45702",
                "cardNumber": "052/064"
            },
            {
                "cardId": "45703",
                "cardNumber": "053/064"
            },
            {
                "cardId": "45704",
                "cardNumber": "054/064"
            },
            {
                "cardId": "45705",
                "cardNumber": "055/064"
            },
            {
                "cardId": "45706",
                "cardNumber": "056/064"
            },
            {
                "cardId": "45707",
                "cardNumber": "057/064"
            },
            {
                "cardId": "45708",
                "cardNumber": "058/064"
            },
            {
                "cardId": "45709",
                "cardNumber": "059/064"
            },
            {
                "cardId": "45710",
                "cardNumber": "060/064"
            },
            {
                "cardId": "45711",
                "cardNumber": "061/064"
            },
            {
                "cardId": "45712",
                "cardNumber": "062/064"
            },
            {
                "cardId": "45713",
                "cardNumber": "063/064"
            },
            {
                "cardId": "45714",
                "cardNumber": "064/064"
            },
            {
                "cardId": "45715",
                "cardNumber": "065/064"
            },
            {
                "cardId": "45716",
                "cardNumber": "066/064"
            },
            {
                "cardId": "45717",
                "cardNumber": "067/064"
            },
            {
                "cardId": "45718",
                "cardNumber": "068/064"
            },
            {
                "cardId": "45719",
                "cardNumber": "069/064"
            },
            {
                "cardId": "45720",
                "cardNumber": "070/064"
            },
            {
                "cardId": "45721",
                "cardNumber": "071/064"
            },
            {
                "cardId": "45722",
                "cardNumber": "072/064"
            },
            {
                "cardId": "45723",
                "cardNumber": "073/064"
            },
            {
                "cardId": "45724",
                "cardNumber": "074/064"
            },
            {
                "cardId": "45725",
                "cardNumber": "075/064"
            },
            {
                "cardId": "45726",
                "cardNumber": "076/064"
            },
            {
                "cardId": "45727",
                "cardNumber": "077/064"
            },
            {
                "cardId": "45728",
                "cardNumber": "078/064"
            },
            {
                "cardId": "45729",
                "cardNumber": "079/064"
            },
            {
                "cardId": "45730",
                "cardNumber": "080/064"
            },
            {
                "cardId": "45731",
                "cardNumber": "081/064"
            },
            {
                "cardId": "45732",
                "cardNumber": "082/064"
            },
            {
                "cardId": "45733",
                "cardNumber": "083/064"
            },
            {
                "cardId": "45734",
                "cardNumber": "084/064"
            },
            {
                "cardId": "45735",
                "cardNumber": "085/064"
            },
            {
                "cardId": "45736",
                "cardNumber": "086/064"
            },
            {
                "cardId": "45737",
                "cardNumber": "087/064"
            },
            {
                "cardId": "45738",
                "cardNumber": "088/064"
            },
            {
                "cardId": "45739",
                "cardNumber": "089/064"
            },
            {
                "cardId": "45740",
                "cardNumber": "090/064"
            },
            {
                "cardId": "45741",
                "cardNumber": "091/064"
            },
            {
                "cardId": "45742",
                "cardNumber": "092/064"
            },
            {
                "cardId": "45743",
                "cardNumber": "093/064"
            },
            {
                "cardId": "45744",
                "cardNumber": "094/064"
            },
            {
                "cardId": "45745",
                "cardNumber": "095/064"
            },
            {
                "cardId": "45746",
                "cardNumber": "096/064"
            },
            {
                "cardId": "45747",
                "cardNumber": "097/064"
            },
            {
                "cardId": "45748",
                "cardNumber": "098/064"
            },
            {
                "cardId": "45749",
                "cardNumber": "099/064"
            }
        ]
    },
    {
        "setPath": "/sets/11625/twilight-masquerade",
        "setCode": "TWM",
        "setId": "11625",
        "totalCards": 167,
        "cards": [
            {
                "cardId": "45038",
                "cardNumber": "001/167"
            },
            {
                "cardId": "45039",
                "cardNumber": "002/167"
            },
            {
                "cardId": "45040",
                "cardNumber": "003/167"
            },
            {
                "cardId": "45041",
                "cardNumber": "004/167"
            },
            {
                "cardId": "45042",
                "cardNumber": "005/167"
            },
            {
                "cardId": "45043",
                "cardNumber": "006/167"
            },
            {
                "cardId": "45044",
                "cardNumber": "007/167"
            },
            {
                "cardId": "45045",
                "cardNumber": "008/167"
            },
            {
                "cardId": "45046",
                "cardNumber": "009/167"
            },
            {
                "cardId": "45047",
                "cardNumber": "010/167"
            },
            {
                "cardId": "45048",
                "cardNumber": "011/167"
            },
            {
                "cardId": "45049",
                "cardNumber": "012/167"
            },
            {
                "cardId": "45050",
                "cardNumber": "013/167"
            },
            {
                "cardId": "45051",
                "cardNumber": "014/167"
            },
            {
                "cardId": "45052",
                "cardNumber": "015/167"
            },
            {
                "cardId": "45053",
                "cardNumber": "016/167"
            },
            {
                "cardId": "45054",
                "cardNumber": "017/167"
            },
            {
                "cardId": "45055",
                "cardNumber": "018/167"
            },
            {
                "cardId": "45056",
                "cardNumber": "019/167"
            },
            {
                "cardId": "45057",
                "cardNumber": "020/167"
            },
            {
                "cardId": "45058",
                "cardNumber": "021/167"
            },
            {
                "cardId": "45059",
                "cardNumber": "022/167"
            },
            {
                "cardId": "45060",
                "cardNumber": "023/167"
            },
            {
                "cardId": "45061",
                "cardNumber": "024/167"
            },
            {
                "cardId": "45062",
                "cardNumber": "025/167"
            },
            {
                "cardId": "45063",
                "cardNumber": "026/167"
            },
            {
                "cardId": "45064",
                "cardNumber": "027/167"
            },
            {
                "cardId": "45065",
                "cardNumber": "028/167"
            },
            {
                "cardId": "45066",
                "cardNumber": "029/167"
            },
            {
                "cardId": "45067",
                "cardNumber": "030/167"
            },
            {
                "cardId": "45068",
                "cardNumber": "031/167"
            },
            {
                "cardId": "45069",
                "cardNumber": "032/167"
            },
            {
                "cardId": "45070",
                "cardNumber": "033/167"
            },
            {
                "cardId": "45071",
                "cardNumber": "034/167"
            },
            {
                "cardId": "45072",
                "cardNumber": "035/167"
            },
            {
                "cardId": "45073",
                "cardNumber": "036/167"
            },
            {
                "cardId": "45074",
                "cardNumber": "037/167"
            },
            {
                "cardId": "45075",
                "cardNumber": "038/167"
            },
            {
                "cardId": "45076",
                "cardNumber": "039/167"
            },
            {
                "cardId": "45077",
                "cardNumber": "040/167"
            },
            {
                "cardId": "45078",
                "cardNumber": "041/167"
            },
            {
                "cardId": "45079",
                "cardNumber": "042/167"
            },
            {
                "cardId": "45080",
                "cardNumber": "043/167"
            },
            {
                "cardId": "45081",
                "cardNumber": "044/167"
            },
            {
                "cardId": "45082",
                "cardNumber": "045/167"
            },
            {
                "cardId": "45083",
                "cardNumber": "046/167"
            },
            {
                "cardId": "45084",
                "cardNumber": "047/167"
            },
            {
                "cardId": "45085",
                "cardNumber": "048/167"
            },
            {
                "cardId": "45086",
                "cardNumber": "049/167"
            },
            {
                "cardId": "45087",
                "cardNumber": "050/167"
            },
            {
                "cardId": "45088",
                "cardNumber": "051/167"
            },
            {
                "cardId": "45089",
                "cardNumber": "052/167"
            },
            {
                "cardId": "45090",
                "cardNumber": "053/167"
            },
            {
                "cardId": "45091",
                "cardNumber": "054/167"
            },
            {
                "cardId": "45092",
                "cardNumber": "055/167"
            },
            {
                "cardId": "45093",
                "cardNumber": "056/167"
            },
            {
                "cardId": "45094",
                "cardNumber": "057/167"
            },
            {
                "cardId": "45095",
                "cardNumber": "058/167"
            },
            {
                "cardId": "45096",
                "cardNumber": "059/167"
            },
            {
                "cardId": "45097",
                "cardNumber": "060/167"
            },
            {
                "cardId": "45098",
                "cardNumber": "061/167"
            },
            {
                "cardId": "45099",
                "cardNumber": "062/167"
            },
            {
                "cardId": "45100",
                "cardNumber": "063/167"
            },
            {
                "cardId": "45101",
                "cardNumber": "064/167"
            },
            {
                "cardId": "45102",
                "cardNumber": "065/167"
            },
            {
                "cardId": "45103",
                "cardNumber": "066/167"
            },
            {
                "cardId": "45104",
                "cardNumber": "067/167"
            },
            {
                "cardId": "45105",
                "cardNumber": "068/167"
            },
            {
                "cardId": "45106",
                "cardNumber": "069/167"
            },
            {
                "cardId": "45107",
                "cardNumber": "070/167"
            },
            {
                "cardId": "45108",
                "cardNumber": "071/167"
            },
            {
                "cardId": "45109",
                "cardNumber": "072/167"
            },
            {
                "cardId": "45110",
                "cardNumber": "073/167"
            },
            {
                "cardId": "45111",
                "cardNumber": "074/167"
            },
            {
                "cardId": "45112",
                "cardNumber": "075/167"
            },
            {
                "cardId": "45113",
                "cardNumber": "076/167"
            },
            {
                "cardId": "45114",
                "cardNumber": "077/167"
            },
            {
                "cardId": "45115",
                "cardNumber": "078/167"
            },
            {
                "cardId": "45116",
                "cardNumber": "079/167"
            },
            {
                "cardId": "45117",
                "cardNumber": "080/167"
            },
            {
                "cardId": "45118",
                "cardNumber": "081/167"
            },
            {
                "cardId": "45119",
                "cardNumber": "082/167"
            },
            {
                "cardId": "45120",
                "cardNumber": "083/167"
            },
            {
                "cardId": "45121",
                "cardNumber": "084/167"
            },
            {
                "cardId": "45122",
                "cardNumber": "085/167"
            },
            {
                "cardId": "45123",
                "cardNumber": "086/167"
            },
            {
                "cardId": "45124",
                "cardNumber": "087/167"
            },
            {
                "cardId": "45125",
                "cardNumber": "088/167"
            },
            {
                "cardId": "45126",
                "cardNumber": "089/167"
            },
            {
                "cardId": "45127",
                "cardNumber": "090/167"
            },
            {
                "cardId": "45128",
                "cardNumber": "091/167"
            },
            {
                "cardId": "45129",
                "cardNumber": "092/167"
            },
            {
                "cardId": "45130",
                "cardNumber": "093/167"
            },
            {
                "cardId": "45131",
                "cardNumber": "094/167"
            },
            {
                "cardId": "45132",
                "cardNumber": "095/167"
            },
            {
                "cardId": "45133",
                "cardNumber": "096/167"
            },
            {
                "cardId": "45134",
                "cardNumber": "097/167"
            },
            {
                "cardId": "45135",
                "cardNumber": "098/167"
            },
            {
                "cardId": "45136",
                "cardNumber": "099/167"
            },
            {
                "cardId": "45137",
                "cardNumber": "100/167"
            },
            {
                "cardId": "45138",
                "cardNumber": "101/167"
            },
            {
                "cardId": "45139",
                "cardNumber": "102/167"
            },
            {
                "cardId": "45140",
                "cardNumber": "103/167"
            },
            {
                "cardId": "45141",
                "cardNumber": "104/167"
            },
            {
                "cardId": "45142",
                "cardNumber": "105/167"
            },
            {
                "cardId": "45143",
                "cardNumber": "106/167"
            },
            {
                "cardId": "45144",
                "cardNumber": "107/167"
            },
            {
                "cardId": "45145",
                "cardNumber": "108/167"
            },
            {
                "cardId": "45146",
                "cardNumber": "109/167"
            },
            {
                "cardId": "45147",
                "cardNumber": "110/167"
            },
            {
                "cardId": "45148",
                "cardNumber": "111/167"
            },
            {
                "cardId": "45149",
                "cardNumber": "112/167"
            },
            {
                "cardId": "45150",
                "cardNumber": "113/167"
            },
            {
                "cardId": "45151",
                "cardNumber": "114/167"
            },
            {
                "cardId": "45152",
                "cardNumber": "115/167"
            },
            {
                "cardId": "45153",
                "cardNumber": "116/167"
            },
            {
                "cardId": "45154",
                "cardNumber": "117/167"
            },
            {
                "cardId": "45155",
                "cardNumber": "118/167"
            },
            {
                "cardId": "45156",
                "cardNumber": "119/167"
            },
            {
                "cardId": "45157",
                "cardNumber": "120/167"
            },
            {
                "cardId": "45158",
                "cardNumber": "121/167"
            },
            {
                "cardId": "45159",
                "cardNumber": "122/167"
            },
            {
                "cardId": "45160",
                "cardNumber": "123/167"
            },
            {
                "cardId": "45161",
                "cardNumber": "124/167"
            },
            {
                "cardId": "45162",
                "cardNumber": "125/167"
            },
            {
                "cardId": "45163",
                "cardNumber": "126/167"
            },
            {
                "cardId": "45164",
                "cardNumber": "127/167"
            },
            {
                "cardId": "45165",
                "cardNumber": "128/167"
            },
            {
                "cardId": "45166",
                "cardNumber": "129/167"
            },
            {
                "cardId": "45167",
                "cardNumber": "130/167"
            },
            {
                "cardId": "45168",
                "cardNumber": "131/167"
            },
            {
                "cardId": "45169",
                "cardNumber": "132/167"
            },
            {
                "cardId": "45170",
                "cardNumber": "133/167"
            },
            {
                "cardId": "45171",
                "cardNumber": "134/167"
            },
            {
                "cardId": "45172",
                "cardNumber": "135/167"
            },
            {
                "cardId": "45173",
                "cardNumber": "136/167"
            },
            {
                "cardId": "45174",
                "cardNumber": "137/167"
            },
            {
                "cardId": "45175",
                "cardNumber": "138/167"
            },
            {
                "cardId": "45176",
                "cardNumber": "139/167"
            },
            {
                "cardId": "45177",
                "cardNumber": "140/167"
            },
            {
                "cardId": "45178",
                "cardNumber": "141/167"
            },
            {
                "cardId": "45179",
                "cardNumber": "142/167"
            },
            {
                "cardId": "45180",
                "cardNumber": "143/167"
            },
            {
                "cardId": "45181",
                "cardNumber": "144/167"
            },
            {
                "cardId": "45182",
                "cardNumber": "145/167"
            },
            {
                "cardId": "45183",
                "cardNumber": "146/167"
            },
            {
                "cardId": "45184",
                "cardNumber": "147/167"
            },
            {
                "cardId": "45185",
                "cardNumber": "148/167"
            },
            {
                "cardId": "45186",
                "cardNumber": "149/167"
            },
            {
                "cardId": "45187",
                "cardNumber": "150/167"
            },
            {
                "cardId": "45188",
                "cardNumber": "151/167"
            },
            {
                "cardId": "45189",
                "cardNumber": "152/167"
            },
            {
                "cardId": "45190",
                "cardNumber": "153/167"
            },
            {
                "cardId": "45191",
                "cardNumber": "154/167"
            },
            {
                "cardId": "45192",
                "cardNumber": "155/167"
            },
            {
                "cardId": "45193",
                "cardNumber": "156/167"
            },
            {
                "cardId": "45194",
                "cardNumber": "157/167"
            },
            {
                "cardId": "45195",
                "cardNumber": "158/167"
            },
            {
                "cardId": "45196",
                "cardNumber": "159/167"
            },
            {
                "cardId": "45197",
                "cardNumber": "160/167"
            },
            {
                "cardId": "45198",
                "cardNumber": "161/167"
            },
            {
                "cardId": "45199",
                "cardNumber": "162/167"
            },
            {
                "cardId": "45200",
                "cardNumber": "163/167"
            },
            {
                "cardId": "45201",
                "cardNumber": "164/167"
            },
            {
                "cardId": "45202",
                "cardNumber": "165/167"
            },
            {
                "cardId": "45203",
                "cardNumber": "166/167"
            },
            {
                "cardId": "45204",
                "cardNumber": "167/167"
            },
            {
                "cardId": "45205",
                "cardNumber": "168/167"
            },
            {
                "cardId": "45206",
                "cardNumber": "169/167"
            },
            {
                "cardId": "45207",
                "cardNumber": "170/167"
            },
            {
                "cardId": "45208",
                "cardNumber": "171/167"
            },
            {
                "cardId": "45209",
                "cardNumber": "172/167"
            },
            {
                "cardId": "45210",
                "cardNumber": "173/167"
            },
            {
                "cardId": "45211",
                "cardNumber": "174/167"
            },
            {
                "cardId": "45212",
                "cardNumber": "175/167"
            },
            {
                "cardId": "45213",
                "cardNumber": "176/167"
            },
            {
                "cardId": "45214",
                "cardNumber": "177/167"
            },
            {
                "cardId": "45215",
                "cardNumber": "178/167"
            },
            {
                "cardId": "45216",
                "cardNumber": "179/167"
            },
            {
                "cardId": "45217",
                "cardNumber": "180/167"
            },
            {
                "cardId": "45218",
                "cardNumber": "181/167"
            },
            {
                "cardId": "45219",
                "cardNumber": "182/167"
            },
            {
                "cardId": "45220",
                "cardNumber": "183/167"
            },
            {
                "cardId": "45221",
                "cardNumber": "184/167"
            },
            {
                "cardId": "45222",
                "cardNumber": "185/167"
            },
            {
                "cardId": "45223",
                "cardNumber": "186/167"
            },
            {
                "cardId": "45224",
                "cardNumber": "187/167"
            },
            {
                "cardId": "45225",
                "cardNumber": "188/167"
            },
            {
                "cardId": "45226",
                "cardNumber": "189/167"
            },
            {
                "cardId": "45227",
                "cardNumber": "190/167"
            },
            {
                "cardId": "45228",
                "cardNumber": "191/167"
            },
            {
                "cardId": "45229",
                "cardNumber": "192/167"
            },
            {
                "cardId": "45230",
                "cardNumber": "193/167"
            },
            {
                "cardId": "45231",
                "cardNumber": "194/167"
            },
            {
                "cardId": "45232",
                "cardNumber": "195/167"
            },
            {
                "cardId": "45233",
                "cardNumber": "196/167"
            },
            {
                "cardId": "45234",
                "cardNumber": "197/167"
            },
            {
                "cardId": "45235",
                "cardNumber": "198/167"
            },
            {
                "cardId": "45236",
                "cardNumber": "199/167"
            },
            {
                "cardId": "45237",
                "cardNumber": "200/167"
            },
            {
                "cardId": "45238",
                "cardNumber": "201/167"
            },
            {
                "cardId": "45239",
                "cardNumber": "202/167"
            },
            {
                "cardId": "45240",
                "cardNumber": "203/167"
            },
            {
                "cardId": "45241",
                "cardNumber": "204/167"
            },
            {
                "cardId": "45242",
                "cardNumber": "205/167"
            },
            {
                "cardId": "45243",
                "cardNumber": "206/167"
            },
            {
                "cardId": "45244",
                "cardNumber": "207/167"
            },
            {
                "cardId": "45245",
                "cardNumber": "208/167"
            },
            {
                "cardId": "45246",
                "cardNumber": "209/167"
            },
            {
                "cardId": "45247",
                "cardNumber": "210/167"
            },
            {
                "cardId": "45248",
                "cardNumber": "211/167"
            },
            {
                "cardId": "45249",
                "cardNumber": "212/167"
            },
            {
                "cardId": "45250",
                "cardNumber": "213/167"
            },
            {
                "cardId": "45251",
                "cardNumber": "214/167"
            },
            {
                "cardId": "45252",
                "cardNumber": "215/167"
            },
            {
                "cardId": "45253",
                "cardNumber": "216/167"
            },
            {
                "cardId": "45254",
                "cardNumber": "217/167"
            },
            {
                "cardId": "45255",
                "cardNumber": "218/167"
            },
            {
                "cardId": "45256",
                "cardNumber": "219/167"
            },
            {
                "cardId": "45257",
                "cardNumber": "220/167"
            },
            {
                "cardId": "45258",
                "cardNumber": "221/167"
            },
            {
                "cardId": "45259",
                "cardNumber": "222/167"
            },
            {
                "cardId": "45260",
                "cardNumber": "223/167"
            },
            {
                "cardId": "45261",
                "cardNumber": "224/167"
            },
            {
                "cardId": "45262",
                "cardNumber": "225/167"
            },
            {
                "cardId": "45263",
                "cardNumber": "226/167"
            }
        ]
    },
    {
        "setPath": "/sets/11605/temporal-forces",
        "setCode": "TEF",
        "setId": "11605",
        "totalCards": 162,
        "cards": [
            {
                "cardId": "44491",
                "cardNumber": "001/162"
            },
            {
                "cardId": "44492",
                "cardNumber": "002/162"
            },
            {
                "cardId": "44493",
                "cardNumber": "003/162"
            },
            {
                "cardId": "44494",
                "cardNumber": "004/162"
            },
            {
                "cardId": "44495",
                "cardNumber": "005/162"
            },
            {
                "cardId": "44496",
                "cardNumber": "006/162"
            },
            {
                "cardId": "44497",
                "cardNumber": "007/162"
            },
            {
                "cardId": "44498",
                "cardNumber": "008/162"
            },
            {
                "cardId": "44499",
                "cardNumber": "009/162"
            },
            {
                "cardId": "44500",
                "cardNumber": "010/162"
            },
            {
                "cardId": "44501",
                "cardNumber": "011/162"
            },
            {
                "cardId": "44502",
                "cardNumber": "012/162"
            },
            {
                "cardId": "44503",
                "cardNumber": "013/162"
            },
            {
                "cardId": "44504",
                "cardNumber": "014/162"
            },
            {
                "cardId": "44505",
                "cardNumber": "015/162"
            },
            {
                "cardId": "44506",
                "cardNumber": "016/162"
            },
            {
                "cardId": "44507",
                "cardNumber": "017/162"
            },
            {
                "cardId": "44508",
                "cardNumber": "018/162"
            },
            {
                "cardId": "44509",
                "cardNumber": "019/162"
            },
            {
                "cardId": "44510",
                "cardNumber": "020/162"
            },
            {
                "cardId": "44511",
                "cardNumber": "021/162"
            },
            {
                "cardId": "44512",
                "cardNumber": "022/162"
            },
            {
                "cardId": "44513",
                "cardNumber": "023/162"
            },
            {
                "cardId": "44514",
                "cardNumber": "024/162"
            },
            {
                "cardId": "44515",
                "cardNumber": "025/162"
            },
            {
                "cardId": "44516",
                "cardNumber": "026/162"
            },
            {
                "cardId": "44517",
                "cardNumber": "027/162"
            },
            {
                "cardId": "44518",
                "cardNumber": "028/162"
            },
            {
                "cardId": "44519",
                "cardNumber": "029/162"
            },
            {
                "cardId": "44520",
                "cardNumber": "030/162"
            },
            {
                "cardId": "44521",
                "cardNumber": "031/162"
            },
            {
                "cardId": "44522",
                "cardNumber": "032/162"
            },
            {
                "cardId": "44523",
                "cardNumber": "033/162"
            },
            {
                "cardId": "44524",
                "cardNumber": "034/162"
            },
            {
                "cardId": "44525",
                "cardNumber": "035/162"
            },
            {
                "cardId": "44526",
                "cardNumber": "036/162"
            },
            {
                "cardId": "44527",
                "cardNumber": "037/162"
            },
            {
                "cardId": "44528",
                "cardNumber": "038/162"
            },
            {
                "cardId": "44529",
                "cardNumber": "039/162"
            },
            {
                "cardId": "44530",
                "cardNumber": "040/162"
            },
            {
                "cardId": "44531",
                "cardNumber": "041/162"
            },
            {
                "cardId": "44532",
                "cardNumber": "042/162"
            },
            {
                "cardId": "44533",
                "cardNumber": "043/162"
            },
            {
                "cardId": "44534",
                "cardNumber": "044/162"
            },
            {
                "cardId": "44535",
                "cardNumber": "045/162"
            },
            {
                "cardId": "44536",
                "cardNumber": "046/162"
            },
            {
                "cardId": "44537",
                "cardNumber": "047/162"
            },
            {
                "cardId": "44538",
                "cardNumber": "048/162"
            },
            {
                "cardId": "44539",
                "cardNumber": "049/162"
            },
            {
                "cardId": "44540",
                "cardNumber": "050/162"
            },
            {
                "cardId": "44541",
                "cardNumber": "051/162"
            },
            {
                "cardId": "44542",
                "cardNumber": "052/162"
            },
            {
                "cardId": "44543",
                "cardNumber": "053/162"
            },
            {
                "cardId": "44544",
                "cardNumber": "054/162"
            },
            {
                "cardId": "44545",
                "cardNumber": "055/162"
            },
            {
                "cardId": "44546",
                "cardNumber": "056/162"
            },
            {
                "cardId": "44547",
                "cardNumber": "057/162"
            },
            {
                "cardId": "44548",
                "cardNumber": "058/162"
            },
            {
                "cardId": "44549",
                "cardNumber": "059/162"
            },
            {
                "cardId": "44550",
                "cardNumber": "060/162"
            },
            {
                "cardId": "44551",
                "cardNumber": "061/162"
            },
            {
                "cardId": "44552",
                "cardNumber": "062/162"
            },
            {
                "cardId": "44553",
                "cardNumber": "063/162"
            },
            {
                "cardId": "44554",
                "cardNumber": "064/162"
            },
            {
                "cardId": "44555",
                "cardNumber": "065/162"
            },
            {
                "cardId": "44556",
                "cardNumber": "066/162"
            },
            {
                "cardId": "44557",
                "cardNumber": "067/162"
            },
            {
                "cardId": "44558",
                "cardNumber": "068/162"
            },
            {
                "cardId": "44559",
                "cardNumber": "069/162"
            },
            {
                "cardId": "44560",
                "cardNumber": "070/162"
            },
            {
                "cardId": "44561",
                "cardNumber": "071/162"
            },
            {
                "cardId": "44562",
                "cardNumber": "072/162"
            },
            {
                "cardId": "44563",
                "cardNumber": "073/162"
            },
            {
                "cardId": "44564",
                "cardNumber": "074/162"
            },
            {
                "cardId": "44565",
                "cardNumber": "075/162"
            },
            {
                "cardId": "44566",
                "cardNumber": "076/162"
            },
            {
                "cardId": "44567",
                "cardNumber": "077/162"
            },
            {
                "cardId": "44568",
                "cardNumber": "078/162"
            },
            {
                "cardId": "44569",
                "cardNumber": "079/162"
            },
            {
                "cardId": "44570",
                "cardNumber": "080/162"
            },
            {
                "cardId": "44571",
                "cardNumber": "081/162"
            },
            {
                "cardId": "44572",
                "cardNumber": "082/162"
            },
            {
                "cardId": "44573",
                "cardNumber": "083/162"
            },
            {
                "cardId": "44574",
                "cardNumber": "084/162"
            },
            {
                "cardId": "44575",
                "cardNumber": "085/162"
            },
            {
                "cardId": "44576",
                "cardNumber": "086/162"
            },
            {
                "cardId": "44577",
                "cardNumber": "087/162"
            },
            {
                "cardId": "44578",
                "cardNumber": "088/162"
            },
            {
                "cardId": "44579",
                "cardNumber": "089/162"
            },
            {
                "cardId": "44580",
                "cardNumber": "090/162"
            },
            {
                "cardId": "44581",
                "cardNumber": "091/162"
            },
            {
                "cardId": "44582",
                "cardNumber": "092/162"
            },
            {
                "cardId": "44583",
                "cardNumber": "093/162"
            },
            {
                "cardId": "44584",
                "cardNumber": "094/162"
            },
            {
                "cardId": "44585",
                "cardNumber": "095/162"
            },
            {
                "cardId": "44586",
                "cardNumber": "096/162"
            },
            {
                "cardId": "44587",
                "cardNumber": "097/162"
            },
            {
                "cardId": "44588",
                "cardNumber": "098/162"
            },
            {
                "cardId": "44589",
                "cardNumber": "099/162"
            },
            {
                "cardId": "44590",
                "cardNumber": "100/162"
            },
            {
                "cardId": "44591",
                "cardNumber": "101/162"
            },
            {
                "cardId": "44592",
                "cardNumber": "102/162"
            },
            {
                "cardId": "44593",
                "cardNumber": "103/162"
            },
            {
                "cardId": "44594",
                "cardNumber": "104/162"
            },
            {
                "cardId": "44595",
                "cardNumber": "105/162"
            },
            {
                "cardId": "44596",
                "cardNumber": "106/162"
            },
            {
                "cardId": "44597",
                "cardNumber": "107/162"
            },
            {
                "cardId": "44598",
                "cardNumber": "108/162"
            },
            {
                "cardId": "44599",
                "cardNumber": "109/162"
            },
            {
                "cardId": "44600",
                "cardNumber": "110/162"
            },
            {
                "cardId": "44601",
                "cardNumber": "111/162"
            },
            {
                "cardId": "44602",
                "cardNumber": "112/162"
            },
            {
                "cardId": "44603",
                "cardNumber": "113/162"
            },
            {
                "cardId": "44604",
                "cardNumber": "114/162"
            },
            {
                "cardId": "44605",
                "cardNumber": "115/162"
            },
            {
                "cardId": "44606",
                "cardNumber": "116/162"
            },
            {
                "cardId": "44607",
                "cardNumber": "117/162"
            },
            {
                "cardId": "44608",
                "cardNumber": "118/162"
            },
            {
                "cardId": "44609",
                "cardNumber": "119/162"
            },
            {
                "cardId": "44610",
                "cardNumber": "120/162"
            },
            {
                "cardId": "44611",
                "cardNumber": "121/162"
            },
            {
                "cardId": "44612",
                "cardNumber": "122/162"
            },
            {
                "cardId": "44613",
                "cardNumber": "123/162"
            },
            {
                "cardId": "44614",
                "cardNumber": "124/162"
            },
            {
                "cardId": "44615",
                "cardNumber": "125/162"
            },
            {
                "cardId": "44616",
                "cardNumber": "126/162"
            },
            {
                "cardId": "44617",
                "cardNumber": "127/162"
            },
            {
                "cardId": "44618",
                "cardNumber": "128/162"
            },
            {
                "cardId": "44619",
                "cardNumber": "129/162"
            },
            {
                "cardId": "44620",
                "cardNumber": "130/162"
            },
            {
                "cardId": "44621",
                "cardNumber": "131/162"
            },
            {
                "cardId": "44622",
                "cardNumber": "132/162"
            },
            {
                "cardId": "44623",
                "cardNumber": "133/162"
            },
            {
                "cardId": "44624",
                "cardNumber": "134/162"
            },
            {
                "cardId": "44625",
                "cardNumber": "135/162"
            },
            {
                "cardId": "44626",
                "cardNumber": "136/162"
            },
            {
                "cardId": "44627",
                "cardNumber": "137/162"
            },
            {
                "cardId": "44628",
                "cardNumber": "138/162"
            },
            {
                "cardId": "44629",
                "cardNumber": "139/162"
            },
            {
                "cardId": "44630",
                "cardNumber": "140/162"
            },
            {
                "cardId": "44631",
                "cardNumber": "141/162"
            },
            {
                "cardId": "44632",
                "cardNumber": "142/162"
            },
            {
                "cardId": "44633",
                "cardNumber": "143/162"
            },
            {
                "cardId": "44634",
                "cardNumber": "144/162"
            },
            {
                "cardId": "44635",
                "cardNumber": "145/162"
            },
            {
                "cardId": "44636",
                "cardNumber": "146/162"
            },
            {
                "cardId": "44637",
                "cardNumber": "147/162"
            },
            {
                "cardId": "44638",
                "cardNumber": "148/162"
            },
            {
                "cardId": "44639",
                "cardNumber": "149/162"
            },
            {
                "cardId": "44640",
                "cardNumber": "150/162"
            },
            {
                "cardId": "44641",
                "cardNumber": "151/162"
            },
            {
                "cardId": "44642",
                "cardNumber": "152/162"
            },
            {
                "cardId": "44643",
                "cardNumber": "153/162"
            },
            {
                "cardId": "44644",
                "cardNumber": "154/162"
            },
            {
                "cardId": "44645",
                "cardNumber": "155/162"
            },
            {
                "cardId": "44646",
                "cardNumber": "156/162"
            },
            {
                "cardId": "44647",
                "cardNumber": "157/162"
            },
            {
                "cardId": "44648",
                "cardNumber": "158/162"
            },
            {
                "cardId": "44649",
                "cardNumber": "159/162"
            },
            {
                "cardId": "44650",
                "cardNumber": "160/162"
            },
            {
                "cardId": "44651",
                "cardNumber": "161/162"
            },
            {
                "cardId": "44652",
                "cardNumber": "162/162"
            },
            {
                "cardId": "44653",
                "cardNumber": "163/162"
            },
            {
                "cardId": "44654",
                "cardNumber": "164/162"
            },
            {
                "cardId": "44655",
                "cardNumber": "165/162"
            },
            {
                "cardId": "44656",
                "cardNumber": "166/162"
            },
            {
                "cardId": "44657",
                "cardNumber": "167/162"
            },
            {
                "cardId": "44658",
                "cardNumber": "168/162"
            },
            {
                "cardId": "44659",
                "cardNumber": "169/162"
            },
            {
                "cardId": "44660",
                "cardNumber": "170/162"
            },
            {
                "cardId": "44661",
                "cardNumber": "171/162"
            },
            {
                "cardId": "44662",
                "cardNumber": "172/162"
            },
            {
                "cardId": "44663",
                "cardNumber": "173/162"
            },
            {
                "cardId": "44664",
                "cardNumber": "174/162"
            },
            {
                "cardId": "44665",
                "cardNumber": "175/162"
            },
            {
                "cardId": "44666",
                "cardNumber": "176/162"
            },
            {
                "cardId": "44667",
                "cardNumber": "177/162"
            },
            {
                "cardId": "44668",
                "cardNumber": "178/162"
            },
            {
                "cardId": "44669",
                "cardNumber": "179/162"
            },
            {
                "cardId": "44670",
                "cardNumber": "180/162"
            },
            {
                "cardId": "44671",
                "cardNumber": "181/162"
            },
            {
                "cardId": "44672",
                "cardNumber": "182/162"
            },
            {
                "cardId": "44673",
                "cardNumber": "183/162"
            },
            {
                "cardId": "44674",
                "cardNumber": "184/162"
            },
            {
                "cardId": "44675",
                "cardNumber": "185/162"
            },
            {
                "cardId": "44676",
                "cardNumber": "186/162"
            },
            {
                "cardId": "44677",
                "cardNumber": "187/162"
            },
            {
                "cardId": "44678",
                "cardNumber": "188/162"
            },
            {
                "cardId": "44679",
                "cardNumber": "189/162"
            },
            {
                "cardId": "44680",
                "cardNumber": "190/162"
            },
            {
                "cardId": "44681",
                "cardNumber": "191/162"
            },
            {
                "cardId": "44682",
                "cardNumber": "192/162"
            },
            {
                "cardId": "44683",
                "cardNumber": "193/162"
            },
            {
                "cardId": "44684",
                "cardNumber": "194/162"
            },
            {
                "cardId": "44685",
                "cardNumber": "195/162"
            },
            {
                "cardId": "44686",
                "cardNumber": "196/162"
            },
            {
                "cardId": "44687",
                "cardNumber": "197/162"
            },
            {
                "cardId": "44688",
                "cardNumber": "198/162"
            },
            {
                "cardId": "44689",
                "cardNumber": "199/162"
            },
            {
                "cardId": "44690",
                "cardNumber": "200/162"
            },
            {
                "cardId": "44691",
                "cardNumber": "201/162"
            },
            {
                "cardId": "44692",
                "cardNumber": "202/162"
            },
            {
                "cardId": "44693",
                "cardNumber": "203/162"
            },
            {
                "cardId": "44694",
                "cardNumber": "204/162"
            },
            {
                "cardId": "44695",
                "cardNumber": "205/162"
            },
            {
                "cardId": "44696",
                "cardNumber": "206/162"
            },
            {
                "cardId": "44697",
                "cardNumber": "207/162"
            },
            {
                "cardId": "44698",
                "cardNumber": "208/162"
            },
            {
                "cardId": "44699",
                "cardNumber": "209/162"
            },
            {
                "cardId": "44700",
                "cardNumber": "210/162"
            },
            {
                "cardId": "44701",
                "cardNumber": "211/162"
            },
            {
                "cardId": "44702",
                "cardNumber": "212/162"
            },
            {
                "cardId": "44703",
                "cardNumber": "213/162"
            },
            {
                "cardId": "44704",
                "cardNumber": "214/162"
            },
            {
                "cardId": "44705",
                "cardNumber": "215/162"
            },
            {
                "cardId": "44706",
                "cardNumber": "216/162"
            },
            {
                "cardId": "44707",
                "cardNumber": "217/162"
            },
            {
                "cardId": "44708",
                "cardNumber": "218/162"
            }
        ]
    },
    {
        "setPath": "/sets/11601/paldean-fates",
        "setCode": "PAF",
        "setId": "11601",
        "totalCards": 91,
        "cards": [
            {
                "cardId": "43921",
                "cardNumber": "001/091"
            },
            {
                "cardId": "43922",
                "cardNumber": "002/091"
            },
            {
                "cardId": "43923",
                "cardNumber": "003/091"
            },
            {
                "cardId": "43924",
                "cardNumber": "004/091"
            },
            {
                "cardId": "43925",
                "cardNumber": "005/091"
            },
            {
                "cardId": "43926",
                "cardNumber": "006/091"
            },
            {
                "cardId": "43927",
                "cardNumber": "007/091"
            },
            {
                "cardId": "43928",
                "cardNumber": "008/091"
            },
            {
                "cardId": "43929",
                "cardNumber": "009/091"
            },
            {
                "cardId": "43930",
                "cardNumber": "010/091"
            },
            {
                "cardId": "43931",
                "cardNumber": "011/091"
            },
            {
                "cardId": "43932",
                "cardNumber": "012/091"
            },
            {
                "cardId": "43933",
                "cardNumber": "013/091"
            },
            {
                "cardId": "43934",
                "cardNumber": "014/091"
            },
            {
                "cardId": "43935",
                "cardNumber": "015/091"
            },
            {
                "cardId": "43936",
                "cardNumber": "016/091"
            },
            {
                "cardId": "43937",
                "cardNumber": "017/091"
            },
            {
                "cardId": "43938",
                "cardNumber": "018/091"
            },
            {
                "cardId": "43939",
                "cardNumber": "019/091"
            },
            {
                "cardId": "43940",
                "cardNumber": "020/091"
            },
            {
                "cardId": "43941",
                "cardNumber": "021/091"
            },
            {
                "cardId": "43942",
                "cardNumber": "022/091"
            },
            {
                "cardId": "43943",
                "cardNumber": "023/091"
            },
            {
                "cardId": "43944",
                "cardNumber": "024/091"
            },
            {
                "cardId": "43945",
                "cardNumber": "025/091"
            },
            {
                "cardId": "43946",
                "cardNumber": "026/091"
            },
            {
                "cardId": "43947",
                "cardNumber": "027/091"
            },
            {
                "cardId": "43948",
                "cardNumber": "028/091"
            },
            {
                "cardId": "43949",
                "cardNumber": "029/091"
            },
            {
                "cardId": "43950",
                "cardNumber": "030/091"
            },
            {
                "cardId": "43951",
                "cardNumber": "031/091"
            },
            {
                "cardId": "43952",
                "cardNumber": "032/091"
            },
            {
                "cardId": "43953",
                "cardNumber": "033/091"
            },
            {
                "cardId": "43954",
                "cardNumber": "034/091"
            },
            {
                "cardId": "43955",
                "cardNumber": "035/091"
            },
            {
                "cardId": "43956",
                "cardNumber": "036/091"
            },
            {
                "cardId": "43957",
                "cardNumber": "037/091"
            },
            {
                "cardId": "43958",
                "cardNumber": "038/091"
            },
            {
                "cardId": "43959",
                "cardNumber": "039/091"
            },
            {
                "cardId": "43960",
                "cardNumber": "040/091"
            },
            {
                "cardId": "43961",
                "cardNumber": "041/091"
            },
            {
                "cardId": "43962",
                "cardNumber": "042/091"
            },
            {
                "cardId": "43963",
                "cardNumber": "043/091"
            },
            {
                "cardId": "43964",
                "cardNumber": "044/091"
            },
            {
                "cardId": "43965",
                "cardNumber": "045/091"
            },
            {
                "cardId": "43966",
                "cardNumber": "046/091"
            },
            {
                "cardId": "43967",
                "cardNumber": "047/091"
            },
            {
                "cardId": "43968",
                "cardNumber": "048/091"
            },
            {
                "cardId": "43969",
                "cardNumber": "049/091"
            },
            {
                "cardId": "43970",
                "cardNumber": "050/091"
            },
            {
                "cardId": "43971",
                "cardNumber": "051/091"
            },
            {
                "cardId": "43972",
                "cardNumber": "052/091"
            },
            {
                "cardId": "43973",
                "cardNumber": "053/091"
            },
            {
                "cardId": "43974",
                "cardNumber": "054/091"
            },
            {
                "cardId": "43975",
                "cardNumber": "055/091"
            },
            {
                "cardId": "43976",
                "cardNumber": "056/091"
            },
            {
                "cardId": "43977",
                "cardNumber": "057/091"
            },
            {
                "cardId": "43978",
                "cardNumber": "058/091"
            },
            {
                "cardId": "43979",
                "cardNumber": "059/091"
            },
            {
                "cardId": "43980",
                "cardNumber": "060/091"
            },
            {
                "cardId": "43981",
                "cardNumber": "061/091"
            },
            {
                "cardId": "43982",
                "cardNumber": "062/091"
            },
            {
                "cardId": "43983",
                "cardNumber": "063/091"
            },
            {
                "cardId": "43984",
                "cardNumber": "064/091"
            },
            {
                "cardId": "43985",
                "cardNumber": "065/091"
            },
            {
                "cardId": "43986",
                "cardNumber": "066/091"
            },
            {
                "cardId": "43987",
                "cardNumber": "067/091"
            },
            {
                "cardId": "43988",
                "cardNumber": "068/091"
            },
            {
                "cardId": "43989",
                "cardNumber": "069/091"
            },
            {
                "cardId": "43990",
                "cardNumber": "070/091"
            },
            {
                "cardId": "43991",
                "cardNumber": "071/091"
            },
            {
                "cardId": "43992",
                "cardNumber": "072/091"
            },
            {
                "cardId": "43993",
                "cardNumber": "073/091"
            },
            {
                "cardId": "43994",
                "cardNumber": "074/091"
            },
            {
                "cardId": "43995",
                "cardNumber": "075/091"
            },
            {
                "cardId": "43996",
                "cardNumber": "076/091"
            },
            {
                "cardId": "43997",
                "cardNumber": "077/091"
            },
            {
                "cardId": "43998",
                "cardNumber": "078/091"
            },
            {
                "cardId": "43999",
                "cardNumber": "079/091"
            },
            {
                "cardId": "44000",
                "cardNumber": "080/091"
            },
            {
                "cardId": "44001",
                "cardNumber": "081/091"
            },
            {
                "cardId": "44002",
                "cardNumber": "082/091"
            },
            {
                "cardId": "44003",
                "cardNumber": "083/091"
            },
            {
                "cardId": "44004",
                "cardNumber": "084/091"
            },
            {
                "cardId": "44005",
                "cardNumber": "085/091"
            },
            {
                "cardId": "44006",
                "cardNumber": "086/091"
            },
            {
                "cardId": "44007",
                "cardNumber": "087/091"
            },
            {
                "cardId": "44008",
                "cardNumber": "088/091"
            },
            {
                "cardId": "44009",
                "cardNumber": "089/091"
            },
            {
                "cardId": "44010",
                "cardNumber": "090/091"
            },
            {
                "cardId": "44011",
                "cardNumber": "091/091"
            },
            {
                "cardId": "44012",
                "cardNumber": "092/091"
            },
            {
                "cardId": "44013",
                "cardNumber": "093/091"
            },
            {
                "cardId": "44014",
                "cardNumber": "094/091"
            },
            {
                "cardId": "44015",
                "cardNumber": "095/091"
            },
            {
                "cardId": "44016",
                "cardNumber": "096/091"
            },
            {
                "cardId": "44017",
                "cardNumber": "097/091"
            },
            {
                "cardId": "44018",
                "cardNumber": "098/091"
            },
            {
                "cardId": "44019",
                "cardNumber": "099/091"
            },
            {
                "cardId": "44020",
                "cardNumber": "100/091"
            },
            {
                "cardId": "44021",
                "cardNumber": "101/091"
            },
            {
                "cardId": "44022",
                "cardNumber": "102/091"
            },
            {
                "cardId": "44023",
                "cardNumber": "103/091"
            },
            {
                "cardId": "44024",
                "cardNumber": "104/091"
            },
            {
                "cardId": "44025",
                "cardNumber": "105/091"
            },
            {
                "cardId": "44026",
                "cardNumber": "106/091"
            },
            {
                "cardId": "44027",
                "cardNumber": "107/091"
            },
            {
                "cardId": "44028",
                "cardNumber": "108/091"
            },
            {
                "cardId": "44029",
                "cardNumber": "109/091"
            },
            {
                "cardId": "44030",
                "cardNumber": "110/091"
            },
            {
                "cardId": "44031",
                "cardNumber": "111/091"
            },
            {
                "cardId": "44032",
                "cardNumber": "112/091"
            },
            {
                "cardId": "44033",
                "cardNumber": "113/091"
            },
            {
                "cardId": "44034",
                "cardNumber": "114/091"
            },
            {
                "cardId": "44035",
                "cardNumber": "115/091"
            },
            {
                "cardId": "44036",
                "cardNumber": "116/091"
            },
            {
                "cardId": "44037",
                "cardNumber": "117/091"
            },
            {
                "cardId": "44038",
                "cardNumber": "118/091"
            },
            {
                "cardId": "44039",
                "cardNumber": "119/091"
            },
            {
                "cardId": "44040",
                "cardNumber": "120/091"
            },
            {
                "cardId": "44041",
                "cardNumber": "121/091"
            },
            {
                "cardId": "44042",
                "cardNumber": "122/091"
            },
            {
                "cardId": "44043",
                "cardNumber": "123/091"
            },
            {
                "cardId": "44044",
                "cardNumber": "124/091"
            },
            {
                "cardId": "44045",
                "cardNumber": "125/091"
            },
            {
                "cardId": "44046",
                "cardNumber": "126/091"
            },
            {
                "cardId": "44047",
                "cardNumber": "127/091"
            },
            {
                "cardId": "44048",
                "cardNumber": "128/091"
            },
            {
                "cardId": "44049",
                "cardNumber": "129/091"
            },
            {
                "cardId": "44050",
                "cardNumber": "130/091"
            },
            {
                "cardId": "44051",
                "cardNumber": "131/091"
            },
            {
                "cardId": "44052",
                "cardNumber": "132/091"
            },
            {
                "cardId": "44053",
                "cardNumber": "133/091"
            },
            {
                "cardId": "44054",
                "cardNumber": "134/091"
            },
            {
                "cardId": "44055",
                "cardNumber": "135/091"
            },
            {
                "cardId": "44056",
                "cardNumber": "136/091"
            },
            {
                "cardId": "44057",
                "cardNumber": "137/091"
            },
            {
                "cardId": "44058",
                "cardNumber": "138/091"
            },
            {
                "cardId": "44059",
                "cardNumber": "139/091"
            },
            {
                "cardId": "44060",
                "cardNumber": "140/091"
            },
            {
                "cardId": "44061",
                "cardNumber": "141/091"
            },
            {
                "cardId": "44062",
                "cardNumber": "142/091"
            },
            {
                "cardId": "44063",
                "cardNumber": "143/091"
            },
            {
                "cardId": "44064",
                "cardNumber": "144/091"
            },
            {
                "cardId": "44065",
                "cardNumber": "145/091"
            },
            {
                "cardId": "44066",
                "cardNumber": "146/091"
            },
            {
                "cardId": "44067",
                "cardNumber": "147/091"
            },
            {
                "cardId": "44068",
                "cardNumber": "148/091"
            },
            {
                "cardId": "44069",
                "cardNumber": "149/091"
            },
            {
                "cardId": "44070",
                "cardNumber": "150/091"
            },
            {
                "cardId": "44071",
                "cardNumber": "151/091"
            },
            {
                "cardId": "44072",
                "cardNumber": "152/091"
            },
            {
                "cardId": "44073",
                "cardNumber": "153/091"
            },
            {
                "cardId": "44074",
                "cardNumber": "154/091"
            },
            {
                "cardId": "44075",
                "cardNumber": "155/091"
            },
            {
                "cardId": "44076",
                "cardNumber": "156/091"
            },
            {
                "cardId": "44077",
                "cardNumber": "157/091"
            },
            {
                "cardId": "44078",
                "cardNumber": "158/091"
            },
            {
                "cardId": "44079",
                "cardNumber": "159/091"
            },
            {
                "cardId": "44080",
                "cardNumber": "160/091"
            },
            {
                "cardId": "44081",
                "cardNumber": "161/091"
            },
            {
                "cardId": "44082",
                "cardNumber": "162/091"
            },
            {
                "cardId": "44083",
                "cardNumber": "163/091"
            },
            {
                "cardId": "44084",
                "cardNumber": "164/091"
            },
            {
                "cardId": "44085",
                "cardNumber": "165/091"
            },
            {
                "cardId": "44086",
                "cardNumber": "166/091"
            },
            {
                "cardId": "44087",
                "cardNumber": "167/091"
            },
            {
                "cardId": "44088",
                "cardNumber": "168/091"
            },
            {
                "cardId": "44089",
                "cardNumber": "169/091"
            },
            {
                "cardId": "44090",
                "cardNumber": "170/091"
            },
            {
                "cardId": "44091",
                "cardNumber": "171/091"
            },
            {
                "cardId": "44092",
                "cardNumber": "172/091"
            },
            {
                "cardId": "44093",
                "cardNumber": "173/091"
            },
            {
                "cardId": "44094",
                "cardNumber": "174/091"
            },
            {
                "cardId": "44095",
                "cardNumber": "175/091"
            },
            {
                "cardId": "44096",
                "cardNumber": "176/091"
            },
            {
                "cardId": "44097",
                "cardNumber": "177/091"
            },
            {
                "cardId": "44098",
                "cardNumber": "178/091"
            },
            {
                "cardId": "44099",
                "cardNumber": "179/091"
            },
            {
                "cardId": "44100",
                "cardNumber": "180/091"
            },
            {
                "cardId": "44101",
                "cardNumber": "181/091"
            },
            {
                "cardId": "44102",
                "cardNumber": "182/091"
            },
            {
                "cardId": "44103",
                "cardNumber": "183/091"
            },
            {
                "cardId": "44104",
                "cardNumber": "184/091"
            },
            {
                "cardId": "44105",
                "cardNumber": "185/091"
            },
            {
                "cardId": "44106",
                "cardNumber": "186/091"
            },
            {
                "cardId": "44107",
                "cardNumber": "187/091"
            },
            {
                "cardId": "44108",
                "cardNumber": "188/091"
            },
            {
                "cardId": "44109",
                "cardNumber": "189/091"
            },
            {
                "cardId": "44110",
                "cardNumber": "190/091"
            },
            {
                "cardId": "44111",
                "cardNumber": "191/091"
            },
            {
                "cardId": "44112",
                "cardNumber": "192/091"
            },
            {
                "cardId": "44113",
                "cardNumber": "193/091"
            },
            {
                "cardId": "44114",
                "cardNumber": "194/091"
            },
            {
                "cardId": "44115",
                "cardNumber": "195/091"
            },
            {
                "cardId": "44116",
                "cardNumber": "196/091"
            },
            {
                "cardId": "44117",
                "cardNumber": "197/091"
            },
            {
                "cardId": "44118",
                "cardNumber": "198/091"
            },
            {
                "cardId": "44119",
                "cardNumber": "199/091"
            },
            {
                "cardId": "44120",
                "cardNumber": "200/091"
            },
            {
                "cardId": "44121",
                "cardNumber": "201/091"
            },
            {
                "cardId": "44122",
                "cardNumber": "202/091"
            },
            {
                "cardId": "44123",
                "cardNumber": "203/091"
            },
            {
                "cardId": "44124",
                "cardNumber": "204/091"
            },
            {
                "cardId": "44125",
                "cardNumber": "205/091"
            },
            {
                "cardId": "44126",
                "cardNumber": "206/091"
            },
            {
                "cardId": "44127",
                "cardNumber": "207/091"
            },
            {
                "cardId": "44128",
                "cardNumber": "208/091"
            },
            {
                "cardId": "44129",
                "cardNumber": "209/091"
            },
            {
                "cardId": "44130",
                "cardNumber": "210/091"
            },
            {
                "cardId": "44131",
                "cardNumber": "211/091"
            },
            {
                "cardId": "44132",
                "cardNumber": "212/091"
            },
            {
                "cardId": "44133",
                "cardNumber": "213/091"
            },
            {
                "cardId": "44134",
                "cardNumber": "214/091"
            },
            {
                "cardId": "44135",
                "cardNumber": "215/091"
            },
            {
                "cardId": "44136",
                "cardNumber": "216/091"
            },
            {
                "cardId": "44137",
                "cardNumber": "217/091"
            },
            {
                "cardId": "44138",
                "cardNumber": "218/091"
            },
            {
                "cardId": "44139",
                "cardNumber": "219/091"
            },
            {
                "cardId": "44140",
                "cardNumber": "220/091"
            },
            {
                "cardId": "44141",
                "cardNumber": "221/091"
            },
            {
                "cardId": "44142",
                "cardNumber": "222/091"
            },
            {
                "cardId": "44143",
                "cardNumber": "223/091"
            },
            {
                "cardId": "44144",
                "cardNumber": "224/091"
            },
            {
                "cardId": "44145",
                "cardNumber": "225/091"
            },
            {
                "cardId": "44146",
                "cardNumber": "226/091"
            },
            {
                "cardId": "44147",
                "cardNumber": "227/091"
            },
            {
                "cardId": "44148",
                "cardNumber": "228/091"
            },
            {
                "cardId": "44149",
                "cardNumber": "229/091"
            },
            {
                "cardId": "44150",
                "cardNumber": "230/091"
            },
            {
                "cardId": "44151",
                "cardNumber": "231/091"
            },
            {
                "cardId": "44152",
                "cardNumber": "232/091"
            },
            {
                "cardId": "44153",
                "cardNumber": "233/091"
            },
            {
                "cardId": "44154",
                "cardNumber": "234/091"
            },
            {
                "cardId": "44155",
                "cardNumber": "235/091"
            },
            {
                "cardId": "44156",
                "cardNumber": "236/091"
            },
            {
                "cardId": "44157",
                "cardNumber": "237/091"
            },
            {
                "cardId": "44158",
                "cardNumber": "238/091"
            },
            {
                "cardId": "44159",
                "cardNumber": "239/091"
            },
            {
                "cardId": "44160",
                "cardNumber": "240/091"
            },
            {
                "cardId": "44161",
                "cardNumber": "241/091"
            },
            {
                "cardId": "44162",
                "cardNumber": "242/091"
            },
            {
                "cardId": "44163",
                "cardNumber": "243/091"
            },
            {
                "cardId": "44164",
                "cardNumber": "244/091"
            },
            {
                "cardId": "44165",
                "cardNumber": "245/091"
            }
        ]
    },
    {
        "setPath": "/sets/11591/paradox-rift",
        "setCode": "PAR",
        "setId": "11591",
        "totalCards": 182,
        "cards": [
            {
                "cardId": "43002",
                "cardNumber": "001/182"
            },
            {
                "cardId": "43003",
                "cardNumber": "002/182"
            },
            {
                "cardId": "43004",
                "cardNumber": "003/182"
            },
            {
                "cardId": "43005",
                "cardNumber": "004/182"
            },
            {
                "cardId": "43006",
                "cardNumber": "005/182"
            },
            {
                "cardId": "43007",
                "cardNumber": "006/182"
            },
            {
                "cardId": "43008",
                "cardNumber": "007/182"
            },
            {
                "cardId": "43009",
                "cardNumber": "008/182"
            },
            {
                "cardId": "43010",
                "cardNumber": "009/182"
            },
            {
                "cardId": "43011",
                "cardNumber": "010/182"
            },
            {
                "cardId": "43012",
                "cardNumber": "011/182"
            },
            {
                "cardId": "43013",
                "cardNumber": "012/182"
            },
            {
                "cardId": "43014",
                "cardNumber": "013/182"
            },
            {
                "cardId": "43015",
                "cardNumber": "014/182"
            },
            {
                "cardId": "43016",
                "cardNumber": "015/182"
            },
            {
                "cardId": "43017",
                "cardNumber": "016/182"
            },
            {
                "cardId": "43018",
                "cardNumber": "017/182"
            },
            {
                "cardId": "43019",
                "cardNumber": "018/182"
            },
            {
                "cardId": "43020",
                "cardNumber": "019/182"
            },
            {
                "cardId": "43021",
                "cardNumber": "020/182"
            },
            {
                "cardId": "43022",
                "cardNumber": "021/182"
            },
            {
                "cardId": "43023",
                "cardNumber": "022/182"
            },
            {
                "cardId": "43024",
                "cardNumber": "023/182"
            },
            {
                "cardId": "43025",
                "cardNumber": "024/182"
            },
            {
                "cardId": "43026",
                "cardNumber": "025/182"
            },
            {
                "cardId": "43027",
                "cardNumber": "026/182"
            },
            {
                "cardId": "43028",
                "cardNumber": "027/182"
            },
            {
                "cardId": "43029",
                "cardNumber": "028/182"
            },
            {
                "cardId": "43030",
                "cardNumber": "029/182"
            },
            {
                "cardId": "43031",
                "cardNumber": "030/182"
            },
            {
                "cardId": "43032",
                "cardNumber": "031/182"
            },
            {
                "cardId": "43033",
                "cardNumber": "032/182"
            },
            {
                "cardId": "43034",
                "cardNumber": "033/182"
            },
            {
                "cardId": "43035",
                "cardNumber": "034/182"
            },
            {
                "cardId": "43036",
                "cardNumber": "035/182"
            },
            {
                "cardId": "43037",
                "cardNumber": "036/182"
            },
            {
                "cardId": "43038",
                "cardNumber": "037/182"
            },
            {
                "cardId": "43039",
                "cardNumber": "038/182"
            },
            {
                "cardId": "43040",
                "cardNumber": "039/182"
            },
            {
                "cardId": "43041",
                "cardNumber": "040/182"
            },
            {
                "cardId": "43042",
                "cardNumber": "041/182"
            },
            {
                "cardId": "43043",
                "cardNumber": "042/182"
            },
            {
                "cardId": "43044",
                "cardNumber": "043/182"
            },
            {
                "cardId": "43045",
                "cardNumber": "044/182"
            },
            {
                "cardId": "43046",
                "cardNumber": "045/182"
            },
            {
                "cardId": "43047",
                "cardNumber": "046/182"
            },
            {
                "cardId": "43048",
                "cardNumber": "047/182"
            },
            {
                "cardId": "43049",
                "cardNumber": "048/182"
            },
            {
                "cardId": "43050",
                "cardNumber": "049/182"
            },
            {
                "cardId": "43051",
                "cardNumber": "050/182"
            },
            {
                "cardId": "43052",
                "cardNumber": "051/182"
            },
            {
                "cardId": "43053",
                "cardNumber": "052/182"
            },
            {
                "cardId": "43054",
                "cardNumber": "053/182"
            },
            {
                "cardId": "43055",
                "cardNumber": "054/182"
            },
            {
                "cardId": "43056",
                "cardNumber": "055/182"
            },
            {
                "cardId": "43057",
                "cardNumber": "056/182"
            },
            {
                "cardId": "43058",
                "cardNumber": "057/182"
            },
            {
                "cardId": "43059",
                "cardNumber": "058/182"
            },
            {
                "cardId": "43060",
                "cardNumber": "059/182"
            },
            {
                "cardId": "43061",
                "cardNumber": "060/182"
            },
            {
                "cardId": "43062",
                "cardNumber": "061/182"
            },
            {
                "cardId": "43063",
                "cardNumber": "062/182"
            },
            {
                "cardId": "43064",
                "cardNumber": "063/182"
            },
            {
                "cardId": "43065",
                "cardNumber": "064/182"
            },
            {
                "cardId": "43066",
                "cardNumber": "065/182"
            },
            {
                "cardId": "43067",
                "cardNumber": "066/182"
            },
            {
                "cardId": "43068",
                "cardNumber": "067/182"
            },
            {
                "cardId": "43069",
                "cardNumber": "068/182"
            },
            {
                "cardId": "43070",
                "cardNumber": "069/182"
            },
            {
                "cardId": "43071",
                "cardNumber": "070/182"
            },
            {
                "cardId": "43072",
                "cardNumber": "071/182"
            },
            {
                "cardId": "43073",
                "cardNumber": "072/182"
            },
            {
                "cardId": "43074",
                "cardNumber": "073/182"
            },
            {
                "cardId": "43075",
                "cardNumber": "074/182"
            },
            {
                "cardId": "43076",
                "cardNumber": "075/182"
            },
            {
                "cardId": "43077",
                "cardNumber": "076/182"
            },
            {
                "cardId": "43078",
                "cardNumber": "077/182"
            },
            {
                "cardId": "43079",
                "cardNumber": "078/182"
            },
            {
                "cardId": "43080",
                "cardNumber": "079/182"
            },
            {
                "cardId": "43081",
                "cardNumber": "080/182"
            },
            {
                "cardId": "43082",
                "cardNumber": "081/182"
            },
            {
                "cardId": "43083",
                "cardNumber": "082/182"
            },
            {
                "cardId": "43084",
                "cardNumber": "083/182"
            },
            {
                "cardId": "43085",
                "cardNumber": "084/182"
            },
            {
                "cardId": "43086",
                "cardNumber": "085/182"
            },
            {
                "cardId": "43087",
                "cardNumber": "086/182"
            },
            {
                "cardId": "43088",
                "cardNumber": "087/182"
            },
            {
                "cardId": "43089",
                "cardNumber": "088/182"
            },
            {
                "cardId": "43090",
                "cardNumber": "089/182"
            },
            {
                "cardId": "43091",
                "cardNumber": "090/182"
            },
            {
                "cardId": "43092",
                "cardNumber": "091/182"
            },
            {
                "cardId": "43093",
                "cardNumber": "092/182"
            },
            {
                "cardId": "43094",
                "cardNumber": "093/182"
            },
            {
                "cardId": "43095",
                "cardNumber": "094/182"
            },
            {
                "cardId": "43096",
                "cardNumber": "095/182"
            },
            {
                "cardId": "43097",
                "cardNumber": "096/182"
            },
            {
                "cardId": "43098",
                "cardNumber": "097/182"
            },
            {
                "cardId": "43099",
                "cardNumber": "098/182"
            },
            {
                "cardId": "43100",
                "cardNumber": "099/182"
            },
            {
                "cardId": "43101",
                "cardNumber": "100/182"
            },
            {
                "cardId": "43102",
                "cardNumber": "101/182"
            },
            {
                "cardId": "43103",
                "cardNumber": "102/182"
            },
            {
                "cardId": "43104",
                "cardNumber": "103/182"
            },
            {
                "cardId": "43105",
                "cardNumber": "104/182"
            },
            {
                "cardId": "43106",
                "cardNumber": "105/182"
            },
            {
                "cardId": "43107",
                "cardNumber": "106/182"
            },
            {
                "cardId": "43108",
                "cardNumber": "107/182"
            },
            {
                "cardId": "43109",
                "cardNumber": "108/182"
            },
            {
                "cardId": "43110",
                "cardNumber": "109/182"
            },
            {
                "cardId": "43111",
                "cardNumber": "110/182"
            },
            {
                "cardId": "43112",
                "cardNumber": "111/182"
            },
            {
                "cardId": "43113",
                "cardNumber": "112/182"
            },
            {
                "cardId": "43114",
                "cardNumber": "113/182"
            },
            {
                "cardId": "43115",
                "cardNumber": "114/182"
            },
            {
                "cardId": "43116",
                "cardNumber": "115/182"
            },
            {
                "cardId": "43117",
                "cardNumber": "116/182"
            },
            {
                "cardId": "43118",
                "cardNumber": "117/182"
            },
            {
                "cardId": "43119",
                "cardNumber": "118/182"
            },
            {
                "cardId": "43120",
                "cardNumber": "119/182"
            },
            {
                "cardId": "43121",
                "cardNumber": "120/182"
            },
            {
                "cardId": "43122",
                "cardNumber": "121/182"
            },
            {
                "cardId": "43123",
                "cardNumber": "122/182"
            },
            {
                "cardId": "43124",
                "cardNumber": "123/182"
            },
            {
                "cardId": "43125",
                "cardNumber": "124/182"
            },
            {
                "cardId": "43126",
                "cardNumber": "125/182"
            },
            {
                "cardId": "43127",
                "cardNumber": "126/182"
            },
            {
                "cardId": "43128",
                "cardNumber": "127/182"
            },
            {
                "cardId": "43129",
                "cardNumber": "128/182"
            },
            {
                "cardId": "43130",
                "cardNumber": "129/182"
            },
            {
                "cardId": "43131",
                "cardNumber": "130/182"
            },
            {
                "cardId": "43132",
                "cardNumber": "131/182"
            },
            {
                "cardId": "43133",
                "cardNumber": "132/182"
            },
            {
                "cardId": "43134",
                "cardNumber": "133/182"
            },
            {
                "cardId": "43135",
                "cardNumber": "134/182"
            },
            {
                "cardId": "43136",
                "cardNumber": "135/182"
            },
            {
                "cardId": "43137",
                "cardNumber": "136/182"
            },
            {
                "cardId": "43138",
                "cardNumber": "137/182"
            },
            {
                "cardId": "43139",
                "cardNumber": "138/182"
            },
            {
                "cardId": "43140",
                "cardNumber": "139/182"
            },
            {
                "cardId": "43141",
                "cardNumber": "140/182"
            },
            {
                "cardId": "43142",
                "cardNumber": "141/182"
            },
            {
                "cardId": "43143",
                "cardNumber": "142/182"
            },
            {
                "cardId": "43144",
                "cardNumber": "143/182"
            },
            {
                "cardId": "43145",
                "cardNumber": "144/182"
            },
            {
                "cardId": "43146",
                "cardNumber": "145/182"
            },
            {
                "cardId": "43147",
                "cardNumber": "146/182"
            },
            {
                "cardId": "43148",
                "cardNumber": "147/182"
            },
            {
                "cardId": "43149",
                "cardNumber": "148/182"
            },
            {
                "cardId": "43150",
                "cardNumber": "149/182"
            },
            {
                "cardId": "43151",
                "cardNumber": "150/182"
            },
            {
                "cardId": "43152",
                "cardNumber": "151/182"
            },
            {
                "cardId": "43153",
                "cardNumber": "152/182"
            },
            {
                "cardId": "43154",
                "cardNumber": "153/182"
            },
            {
                "cardId": "43155",
                "cardNumber": "154/182"
            },
            {
                "cardId": "43156",
                "cardNumber": "155/182"
            },
            {
                "cardId": "43157",
                "cardNumber": "156/182"
            },
            {
                "cardId": "43158",
                "cardNumber": "157/182"
            },
            {
                "cardId": "43159",
                "cardNumber": "158/182"
            },
            {
                "cardId": "43160",
                "cardNumber": "159/182"
            },
            {
                "cardId": "43161",
                "cardNumber": "160/182"
            },
            {
                "cardId": "43162",
                "cardNumber": "161/182"
            },
            {
                "cardId": "43163",
                "cardNumber": "162/182"
            },
            {
                "cardId": "43164",
                "cardNumber": "163/182"
            },
            {
                "cardId": "43165",
                "cardNumber": "164/182"
            },
            {
                "cardId": "43166",
                "cardNumber": "165/182"
            },
            {
                "cardId": "43167",
                "cardNumber": "166/182"
            },
            {
                "cardId": "43168",
                "cardNumber": "167/182"
            },
            {
                "cardId": "43169",
                "cardNumber": "168/182"
            },
            {
                "cardId": "43170",
                "cardNumber": "169/182"
            },
            {
                "cardId": "43171",
                "cardNumber": "170/182"
            },
            {
                "cardId": "43172",
                "cardNumber": "171/182"
            },
            {
                "cardId": "43173",
                "cardNumber": "172/182"
            },
            {
                "cardId": "43174",
                "cardNumber": "173/182"
            },
            {
                "cardId": "43175",
                "cardNumber": "174/182"
            },
            {
                "cardId": "43176",
                "cardNumber": "175/182"
            },
            {
                "cardId": "43177",
                "cardNumber": "176/182"
            },
            {
                "cardId": "43178",
                "cardNumber": "177/182"
            },
            {
                "cardId": "43179",
                "cardNumber": "178/182"
            },
            {
                "cardId": "43180",
                "cardNumber": "179/182"
            },
            {
                "cardId": "43181",
                "cardNumber": "180/182"
            },
            {
                "cardId": "43182",
                "cardNumber": "181/182"
            },
            {
                "cardId": "43183",
                "cardNumber": "182/182"
            },
            {
                "cardId": "43184",
                "cardNumber": "183/182"
            },
            {
                "cardId": "43185",
                "cardNumber": "184/182"
            },
            {
                "cardId": "43186",
                "cardNumber": "185/182"
            },
            {
                "cardId": "43187",
                "cardNumber": "186/182"
            },
            {
                "cardId": "43188",
                "cardNumber": "187/182"
            },
            {
                "cardId": "43189",
                "cardNumber": "188/182"
            },
            {
                "cardId": "43190",
                "cardNumber": "189/182"
            },
            {
                "cardId": "43191",
                "cardNumber": "190/182"
            },
            {
                "cardId": "43192",
                "cardNumber": "191/182"
            },
            {
                "cardId": "43193",
                "cardNumber": "192/182"
            },
            {
                "cardId": "43194",
                "cardNumber": "193/182"
            },
            {
                "cardId": "43195",
                "cardNumber": "194/182"
            },
            {
                "cardId": "43196",
                "cardNumber": "195/182"
            },
            {
                "cardId": "43197",
                "cardNumber": "196/182"
            },
            {
                "cardId": "43198",
                "cardNumber": "197/182"
            },
            {
                "cardId": "43199",
                "cardNumber": "198/182"
            },
            {
                "cardId": "43200",
                "cardNumber": "199/182"
            },
            {
                "cardId": "43201",
                "cardNumber": "200/182"
            },
            {
                "cardId": "43202",
                "cardNumber": "201/182"
            },
            {
                "cardId": "43203",
                "cardNumber": "202/182"
            },
            {
                "cardId": "43204",
                "cardNumber": "203/182"
            },
            {
                "cardId": "43205",
                "cardNumber": "204/182"
            },
            {
                "cardId": "43206",
                "cardNumber": "205/182"
            },
            {
                "cardId": "43207",
                "cardNumber": "206/182"
            },
            {
                "cardId": "43208",
                "cardNumber": "207/182"
            },
            {
                "cardId": "43209",
                "cardNumber": "208/182"
            },
            {
                "cardId": "43210",
                "cardNumber": "209/182"
            },
            {
                "cardId": "43211",
                "cardNumber": "210/182"
            },
            {
                "cardId": "43212",
                "cardNumber": "211/182"
            },
            {
                "cardId": "43213",
                "cardNumber": "212/182"
            },
            {
                "cardId": "43214",
                "cardNumber": "213/182"
            },
            {
                "cardId": "43215",
                "cardNumber": "214/182"
            },
            {
                "cardId": "43216",
                "cardNumber": "215/182"
            },
            {
                "cardId": "43217",
                "cardNumber": "216/182"
            },
            {
                "cardId": "43218",
                "cardNumber": "217/182"
            },
            {
                "cardId": "43219",
                "cardNumber": "218/182"
            },
            {
                "cardId": "43220",
                "cardNumber": "219/182"
            },
            {
                "cardId": "43221",
                "cardNumber": "220/182"
            },
            {
                "cardId": "43222",
                "cardNumber": "221/182"
            },
            {
                "cardId": "43223",
                "cardNumber": "222/182"
            },
            {
                "cardId": "43224",
                "cardNumber": "223/182"
            },
            {
                "cardId": "43225",
                "cardNumber": "224/182"
            },
            {
                "cardId": "43226",
                "cardNumber": "225/182"
            },
            {
                "cardId": "43227",
                "cardNumber": "226/182"
            },
            {
                "cardId": "43228",
                "cardNumber": "227/182"
            },
            {
                "cardId": "43229",
                "cardNumber": "228/182"
            },
            {
                "cardId": "43230",
                "cardNumber": "229/182"
            },
            {
                "cardId": "43231",
                "cardNumber": "230/182"
            },
            {
                "cardId": "43232",
                "cardNumber": "231/182"
            },
            {
                "cardId": "43233",
                "cardNumber": "232/182"
            },
            {
                "cardId": "43234",
                "cardNumber": "233/182"
            },
            {
                "cardId": "43235",
                "cardNumber": "234/182"
            },
            {
                "cardId": "43236",
                "cardNumber": "235/182"
            },
            {
                "cardId": "43237",
                "cardNumber": "236/182"
            },
            {
                "cardId": "43238",
                "cardNumber": "237/182"
            },
            {
                "cardId": "43239",
                "cardNumber": "238/182"
            },
            {
                "cardId": "43240",
                "cardNumber": "239/182"
            },
            {
                "cardId": "43241",
                "cardNumber": "240/182"
            },
            {
                "cardId": "43242",
                "cardNumber": "241/182"
            },
            {
                "cardId": "43243",
                "cardNumber": "242/182"
            },
            {
                "cardId": "43244",
                "cardNumber": "243/182"
            },
            {
                "cardId": "43245",
                "cardNumber": "244/182"
            },
            {
                "cardId": "43246",
                "cardNumber": "245/182"
            },
            {
                "cardId": "43247",
                "cardNumber": "246/182"
            },
            {
                "cardId": "43248",
                "cardNumber": "247/182"
            },
            {
                "cardId": "43249",
                "cardNumber": "248/182"
            },
            {
                "cardId": "43250",
                "cardNumber": "249/182"
            },
            {
                "cardId": "43251",
                "cardNumber": "250/182"
            },
            {
                "cardId": "43252",
                "cardNumber": "251/182"
            },
            {
                "cardId": "43253",
                "cardNumber": "252/182"
            },
            {
                "cardId": "43254",
                "cardNumber": "253/182"
            },
            {
                "cardId": "43255",
                "cardNumber": "254/182"
            },
            {
                "cardId": "43256",
                "cardNumber": "255/182"
            },
            {
                "cardId": "43257",
                "cardNumber": "256/182"
            },
            {
                "cardId": "43258",
                "cardNumber": "257/182"
            },
            {
                "cardId": "43259",
                "cardNumber": "258/182"
            },
            {
                "cardId": "43260",
                "cardNumber": "259/182"
            },
            {
                "cardId": "43261",
                "cardNumber": "260/182"
            },
            {
                "cardId": "43262",
                "cardNumber": "261/182"
            },
            {
                "cardId": "43263",
                "cardNumber": "262/182"
            },
            {
                "cardId": "43264",
                "cardNumber": "263/182"
            },
            {
                "cardId": "43265",
                "cardNumber": "264/182"
            },
            {
                "cardId": "43266",
                "cardNumber": "265/182"
            },
            {
                "cardId": "43267",
                "cardNumber": "266/182"
            }
        ]
    },
    {
        "setPath": "/sets/11584/scarlet-and-violet-151",
        "setCode": "MEW",
        "setId": "11584",
        "totalCards": 165,
        "cards": [
            {
                "cardId": "42370",
                "cardNumber": "001/165"
            },
            {
                "cardId": "42371",
                "cardNumber": "002/165"
            },
            {
                "cardId": "42372",
                "cardNumber": "003/165"
            },
            {
                "cardId": "42373",
                "cardNumber": "004/165"
            },
            {
                "cardId": "42374",
                "cardNumber": "005/165"
            },
            {
                "cardId": "42375",
                "cardNumber": "006/165"
            },
            {
                "cardId": "42376",
                "cardNumber": "007/165"
            },
            {
                "cardId": "42377",
                "cardNumber": "008/165"
            },
            {
                "cardId": "42378",
                "cardNumber": "009/165"
            },
            {
                "cardId": "42379",
                "cardNumber": "010/165"
            },
            {
                "cardId": "42380",
                "cardNumber": "011/165"
            },
            {
                "cardId": "42381",
                "cardNumber": "012/165"
            },
            {
                "cardId": "42382",
                "cardNumber": "013/165"
            },
            {
                "cardId": "42383",
                "cardNumber": "014/165"
            },
            {
                "cardId": "42384",
                "cardNumber": "015/165"
            },
            {
                "cardId": "42385",
                "cardNumber": "016/165"
            },
            {
                "cardId": "42386",
                "cardNumber": "017/165"
            },
            {
                "cardId": "42387",
                "cardNumber": "018/165"
            },
            {
                "cardId": "42388",
                "cardNumber": "019/165"
            },
            {
                "cardId": "42389",
                "cardNumber": "020/165"
            },
            {
                "cardId": "42390",
                "cardNumber": "021/165"
            },
            {
                "cardId": "42391",
                "cardNumber": "022/165"
            },
            {
                "cardId": "42392",
                "cardNumber": "023/165"
            },
            {
                "cardId": "42393",
                "cardNumber": "024/165"
            },
            {
                "cardId": "42394",
                "cardNumber": "025/165"
            },
            {
                "cardId": "42395",
                "cardNumber": "026/165"
            },
            {
                "cardId": "42396",
                "cardNumber": "027/165"
            },
            {
                "cardId": "42397",
                "cardNumber": "028/165"
            },
            {
                "cardId": "42398",
                "cardNumber": "029/165"
            },
            {
                "cardId": "42399",
                "cardNumber": "030/165"
            },
            {
                "cardId": "42400",
                "cardNumber": "031/165"
            },
            {
                "cardId": "42401",
                "cardNumber": "032/165"
            },
            {
                "cardId": "42402",
                "cardNumber": "033/165"
            },
            {
                "cardId": "42403",
                "cardNumber": "034/165"
            },
            {
                "cardId": "42404",
                "cardNumber": "035/165"
            },
            {
                "cardId": "42405",
                "cardNumber": "036/165"
            },
            {
                "cardId": "42406",
                "cardNumber": "037/165"
            },
            {
                "cardId": "42407",
                "cardNumber": "038/165"
            },
            {
                "cardId": "42408",
                "cardNumber": "039/165"
            },
            {
                "cardId": "42409",
                "cardNumber": "040/165"
            },
            {
                "cardId": "42410",
                "cardNumber": "041/165"
            },
            {
                "cardId": "42411",
                "cardNumber": "042/165"
            },
            {
                "cardId": "42412",
                "cardNumber": "043/165"
            },
            {
                "cardId": "42413",
                "cardNumber": "044/165"
            },
            {
                "cardId": "42414",
                "cardNumber": "045/165"
            },
            {
                "cardId": "42415",
                "cardNumber": "046/165"
            },
            {
                "cardId": "42416",
                "cardNumber": "047/165"
            },
            {
                "cardId": "42417",
                "cardNumber": "048/165"
            },
            {
                "cardId": "42418",
                "cardNumber": "049/165"
            },
            {
                "cardId": "42419",
                "cardNumber": "050/165"
            },
            {
                "cardId": "42420",
                "cardNumber": "051/165"
            },
            {
                "cardId": "42421",
                "cardNumber": "052/165"
            },
            {
                "cardId": "42422",
                "cardNumber": "053/165"
            },
            {
                "cardId": "42423",
                "cardNumber": "054/165"
            },
            {
                "cardId": "42424",
                "cardNumber": "055/165"
            },
            {
                "cardId": "42425",
                "cardNumber": "056/165"
            },
            {
                "cardId": "42426",
                "cardNumber": "057/165"
            },
            {
                "cardId": "42427",
                "cardNumber": "058/165"
            },
            {
                "cardId": "42428",
                "cardNumber": "059/165"
            },
            {
                "cardId": "42429",
                "cardNumber": "060/165"
            },
            {
                "cardId": "42430",
                "cardNumber": "061/165"
            },
            {
                "cardId": "42431",
                "cardNumber": "062/165"
            },
            {
                "cardId": "42432",
                "cardNumber": "063/165"
            },
            {
                "cardId": "42433",
                "cardNumber": "064/165"
            },
            {
                "cardId": "42434",
                "cardNumber": "065/165"
            },
            {
                "cardId": "42435",
                "cardNumber": "066/165"
            },
            {
                "cardId": "42436",
                "cardNumber": "067/165"
            },
            {
                "cardId": "42437",
                "cardNumber": "068/165"
            },
            {
                "cardId": "42438",
                "cardNumber": "069/165"
            },
            {
                "cardId": "42439",
                "cardNumber": "070/165"
            },
            {
                "cardId": "42440",
                "cardNumber": "071/165"
            },
            {
                "cardId": "42441",
                "cardNumber": "072/165"
            },
            {
                "cardId": "42442",
                "cardNumber": "073/165"
            },
            {
                "cardId": "42443",
                "cardNumber": "074/165"
            },
            {
                "cardId": "42444",
                "cardNumber": "075/165"
            },
            {
                "cardId": "42445",
                "cardNumber": "076/165"
            },
            {
                "cardId": "42446",
                "cardNumber": "077/165"
            },
            {
                "cardId": "42447",
                "cardNumber": "078/165"
            },
            {
                "cardId": "42448",
                "cardNumber": "079/165"
            },
            {
                "cardId": "42449",
                "cardNumber": "080/165"
            },
            {
                "cardId": "42450",
                "cardNumber": "081/165"
            },
            {
                "cardId": "42451",
                "cardNumber": "082/165"
            },
            {
                "cardId": "42452",
                "cardNumber": "083/165"
            },
            {
                "cardId": "42453",
                "cardNumber": "084/165"
            },
            {
                "cardId": "42454",
                "cardNumber": "085/165"
            },
            {
                "cardId": "42455",
                "cardNumber": "086/165"
            },
            {
                "cardId": "42456",
                "cardNumber": "087/165"
            },
            {
                "cardId": "42457",
                "cardNumber": "088/165"
            },
            {
                "cardId": "42458",
                "cardNumber": "089/165"
            },
            {
                "cardId": "42459",
                "cardNumber": "090/165"
            },
            {
                "cardId": "42460",
                "cardNumber": "091/165"
            },
            {
                "cardId": "42461",
                "cardNumber": "092/165"
            },
            {
                "cardId": "42462",
                "cardNumber": "093/165"
            },
            {
                "cardId": "42463",
                "cardNumber": "094/165"
            },
            {
                "cardId": "42464",
                "cardNumber": "095/165"
            },
            {
                "cardId": "42465",
                "cardNumber": "096/165"
            },
            {
                "cardId": "42466",
                "cardNumber": "097/165"
            },
            {
                "cardId": "42467",
                "cardNumber": "098/165"
            },
            {
                "cardId": "42468",
                "cardNumber": "099/165"
            },
            {
                "cardId": "42469",
                "cardNumber": "100/165"
            },
            {
                "cardId": "42470",
                "cardNumber": "101/165"
            },
            {
                "cardId": "42471",
                "cardNumber": "102/165"
            },
            {
                "cardId": "42472",
                "cardNumber": "103/165"
            },
            {
                "cardId": "42473",
                "cardNumber": "104/165"
            },
            {
                "cardId": "42474",
                "cardNumber": "105/165"
            },
            {
                "cardId": "42475",
                "cardNumber": "106/165"
            },
            {
                "cardId": "42476",
                "cardNumber": "107/165"
            },
            {
                "cardId": "42477",
                "cardNumber": "108/165"
            },
            {
                "cardId": "42478",
                "cardNumber": "109/165"
            },
            {
                "cardId": "42479",
                "cardNumber": "110/165"
            },
            {
                "cardId": "42480",
                "cardNumber": "111/165"
            },
            {
                "cardId": "42481",
                "cardNumber": "112/165"
            },
            {
                "cardId": "42482",
                "cardNumber": "113/165"
            },
            {
                "cardId": "42483",
                "cardNumber": "114/165"
            },
            {
                "cardId": "42484",
                "cardNumber": "115/165"
            },
            {
                "cardId": "42485",
                "cardNumber": "116/165"
            },
            {
                "cardId": "42486",
                "cardNumber": "117/165"
            },
            {
                "cardId": "42487",
                "cardNumber": "118/165"
            },
            {
                "cardId": "42488",
                "cardNumber": "119/165"
            },
            {
                "cardId": "42489",
                "cardNumber": "120/165"
            },
            {
                "cardId": "42490",
                "cardNumber": "121/165"
            },
            {
                "cardId": "42491",
                "cardNumber": "122/165"
            },
            {
                "cardId": "42492",
                "cardNumber": "123/165"
            },
            {
                "cardId": "42493",
                "cardNumber": "124/165"
            },
            {
                "cardId": "42494",
                "cardNumber": "125/165"
            },
            {
                "cardId": "42495",
                "cardNumber": "126/165"
            },
            {
                "cardId": "42496",
                "cardNumber": "127/165"
            },
            {
                "cardId": "42497",
                "cardNumber": "128/165"
            },
            {
                "cardId": "42498",
                "cardNumber": "129/165"
            },
            {
                "cardId": "42499",
                "cardNumber": "130/165"
            },
            {
                "cardId": "42500",
                "cardNumber": "131/165"
            },
            {
                "cardId": "42501",
                "cardNumber": "132/165"
            },
            {
                "cardId": "42502",
                "cardNumber": "133/165"
            },
            {
                "cardId": "42503",
                "cardNumber": "134/165"
            },
            {
                "cardId": "42504",
                "cardNumber": "135/165"
            },
            {
                "cardId": "42505",
                "cardNumber": "136/165"
            },
            {
                "cardId": "42506",
                "cardNumber": "137/165"
            },
            {
                "cardId": "42507",
                "cardNumber": "138/165"
            },
            {
                "cardId": "42508",
                "cardNumber": "139/165"
            },
            {
                "cardId": "42509",
                "cardNumber": "140/165"
            },
            {
                "cardId": "42510",
                "cardNumber": "141/165"
            },
            {
                "cardId": "42511",
                "cardNumber": "142/165"
            },
            {
                "cardId": "42512",
                "cardNumber": "143/165"
            },
            {
                "cardId": "42513",
                "cardNumber": "144/165"
            },
            {
                "cardId": "42514",
                "cardNumber": "145/165"
            },
            {
                "cardId": "42515",
                "cardNumber": "146/165"
            },
            {
                "cardId": "42516",
                "cardNumber": "147/165"
            },
            {
                "cardId": "42517",
                "cardNumber": "148/165"
            },
            {
                "cardId": "42518",
                "cardNumber": "149/165"
            },
            {
                "cardId": "42519",
                "cardNumber": "150/165"
            },
            {
                "cardId": "42520",
                "cardNumber": "151/165"
            },
            {
                "cardId": "42521",
                "cardNumber": "152/165"
            },
            {
                "cardId": "42522",
                "cardNumber": "153/165"
            },
            {
                "cardId": "42523",
                "cardNumber": "154/165"
            },
            {
                "cardId": "42524",
                "cardNumber": "155/165"
            },
            {
                "cardId": "42525",
                "cardNumber": "156/165"
            },
            {
                "cardId": "42526",
                "cardNumber": "157/165"
            },
            {
                "cardId": "42527",
                "cardNumber": "158/165"
            },
            {
                "cardId": "42528",
                "cardNumber": "159/165"
            },
            {
                "cardId": "42529",
                "cardNumber": "160/165"
            },
            {
                "cardId": "42530",
                "cardNumber": "161/165"
            },
            {
                "cardId": "42531",
                "cardNumber": "162/165"
            },
            {
                "cardId": "42532",
                "cardNumber": "163/165"
            },
            {
                "cardId": "42533",
                "cardNumber": "164/165"
            },
            {
                "cardId": "42534",
                "cardNumber": "165/165"
            },
            {
                "cardId": "42535",
                "cardNumber": "166/165"
            },
            {
                "cardId": "42536",
                "cardNumber": "167/165"
            },
            {
                "cardId": "42537",
                "cardNumber": "168/165"
            },
            {
                "cardId": "42538",
                "cardNumber": "169/165"
            },
            {
                "cardId": "42539",
                "cardNumber": "170/165"
            },
            {
                "cardId": "42540",
                "cardNumber": "171/165"
            },
            {
                "cardId": "42541",
                "cardNumber": "172/165"
            },
            {
                "cardId": "42542",
                "cardNumber": "173/165"
            },
            {
                "cardId": "42543",
                "cardNumber": "174/165"
            },
            {
                "cardId": "42544",
                "cardNumber": "175/165"
            },
            {
                "cardId": "42545",
                "cardNumber": "176/165"
            },
            {
                "cardId": "42546",
                "cardNumber": "177/165"
            },
            {
                "cardId": "42547",
                "cardNumber": "178/165"
            },
            {
                "cardId": "42548",
                "cardNumber": "179/165"
            },
            {
                "cardId": "42549",
                "cardNumber": "180/165"
            },
            {
                "cardId": "42550",
                "cardNumber": "181/165"
            },
            {
                "cardId": "42551",
                "cardNumber": "182/165"
            },
            {
                "cardId": "42552",
                "cardNumber": "183/165"
            },
            {
                "cardId": "42553",
                "cardNumber": "184/165"
            },
            {
                "cardId": "42554",
                "cardNumber": "185/165"
            },
            {
                "cardId": "42555",
                "cardNumber": "186/165"
            },
            {
                "cardId": "42556",
                "cardNumber": "187/165"
            },
            {
                "cardId": "42557",
                "cardNumber": "188/165"
            },
            {
                "cardId": "42558",
                "cardNumber": "189/165"
            },
            {
                "cardId": "42559",
                "cardNumber": "190/165"
            },
            {
                "cardId": "42560",
                "cardNumber": "191/165"
            },
            {
                "cardId": "42561",
                "cardNumber": "192/165"
            },
            {
                "cardId": "42562",
                "cardNumber": "193/165"
            },
            {
                "cardId": "42563",
                "cardNumber": "194/165"
            },
            {
                "cardId": "42564",
                "cardNumber": "195/165"
            },
            {
                "cardId": "42565",
                "cardNumber": "196/165"
            },
            {
                "cardId": "42566",
                "cardNumber": "197/165"
            },
            {
                "cardId": "42567",
                "cardNumber": "198/165"
            },
            {
                "cardId": "42568",
                "cardNumber": "199/165"
            },
            {
                "cardId": "42569",
                "cardNumber": "200/165"
            },
            {
                "cardId": "42570",
                "cardNumber": "201/165"
            },
            {
                "cardId": "42571",
                "cardNumber": "202/165"
            },
            {
                "cardId": "42572",
                "cardNumber": "203/165"
            },
            {
                "cardId": "42573",
                "cardNumber": "204/165"
            },
            {
                "cardId": "42574",
                "cardNumber": "205/165"
            },
            {
                "cardId": "42575",
                "cardNumber": "206/165"
            },
            {
                "cardId": "42576",
                "cardNumber": "207/165"
            }
        ]
    },
    {
        "setPath": "/sets/11581/obsidian-flames",
        "setCode": "OBF",
        "setId": "11581",
        "totalCards": 197,
        "cards": [
            {
                "cardId": "42096",
                "cardNumber": "001/197"
            },
            {
                "cardId": "42098",
                "cardNumber": "002/197"
            },
            {
                "cardId": "42100",
                "cardNumber": "003/197"
            },
            {
                "cardId": "42102",
                "cardNumber": "004/197"
            },
            {
                "cardId": "42104",
                "cardNumber": "005/197"
            },
            {
                "cardId": "42106",
                "cardNumber": "006/197"
            },
            {
                "cardId": "42108",
                "cardNumber": "007/197"
            },
            {
                "cardId": "42110",
                "cardNumber": "008/197"
            },
            {
                "cardId": "42112",
                "cardNumber": "009/197"
            },
            {
                "cardId": "42114",
                "cardNumber": "010/197"
            },
            {
                "cardId": "42116",
                "cardNumber": "011/197"
            },
            {
                "cardId": "42118",
                "cardNumber": "012/197"
            },
            {
                "cardId": "42120",
                "cardNumber": "013/197"
            },
            {
                "cardId": "42122",
                "cardNumber": "014/197"
            },
            {
                "cardId": "42124",
                "cardNumber": "015/197"
            },
            {
                "cardId": "42125",
                "cardNumber": "016/197"
            },
            {
                "cardId": "42126",
                "cardNumber": "017/197"
            },
            {
                "cardId": "42127",
                "cardNumber": "018/197"
            },
            {
                "cardId": "42128",
                "cardNumber": "019/197"
            },
            {
                "cardId": "42129",
                "cardNumber": "020/197"
            },
            {
                "cardId": "42130",
                "cardNumber": "021/197"
            },
            {
                "cardId": "42131",
                "cardNumber": "022/197"
            },
            {
                "cardId": "42132",
                "cardNumber": "023/197"
            },
            {
                "cardId": "42133",
                "cardNumber": "024/197"
            },
            {
                "cardId": "42134",
                "cardNumber": "025/197"
            },
            {
                "cardId": "42135",
                "cardNumber": "026/197"
            },
            {
                "cardId": "42136",
                "cardNumber": "027/197"
            },
            {
                "cardId": "42137",
                "cardNumber": "028/197"
            },
            {
                "cardId": "42138",
                "cardNumber": "029/197"
            },
            {
                "cardId": "42139",
                "cardNumber": "030/197"
            },
            {
                "cardId": "42140",
                "cardNumber": "031/197"
            },
            {
                "cardId": "42141",
                "cardNumber": "032/197"
            },
            {
                "cardId": "42142",
                "cardNumber": "033/197"
            },
            {
                "cardId": "42143",
                "cardNumber": "034/197"
            },
            {
                "cardId": "42144",
                "cardNumber": "035/197"
            },
            {
                "cardId": "42145",
                "cardNumber": "036/197"
            },
            {
                "cardId": "42146",
                "cardNumber": "037/197"
            },
            {
                "cardId": "42147",
                "cardNumber": "038/197"
            },
            {
                "cardId": "42148",
                "cardNumber": "039/197"
            },
            {
                "cardId": "42149",
                "cardNumber": "040/197"
            },
            {
                "cardId": "42150",
                "cardNumber": "041/197"
            },
            {
                "cardId": "42151",
                "cardNumber": "042/197"
            },
            {
                "cardId": "42152",
                "cardNumber": "043/197"
            },
            {
                "cardId": "42153",
                "cardNumber": "044/197"
            },
            {
                "cardId": "42154",
                "cardNumber": "045/197"
            },
            {
                "cardId": "42155",
                "cardNumber": "046/197"
            },
            {
                "cardId": "42156",
                "cardNumber": "047/197"
            },
            {
                "cardId": "42157",
                "cardNumber": "048/197"
            },
            {
                "cardId": "42158",
                "cardNumber": "049/197"
            },
            {
                "cardId": "42159",
                "cardNumber": "050/197"
            },
            {
                "cardId": "42160",
                "cardNumber": "051/197"
            },
            {
                "cardId": "42161",
                "cardNumber": "052/197"
            },
            {
                "cardId": "42162",
                "cardNumber": "053/197"
            },
            {
                "cardId": "42163",
                "cardNumber": "054/197"
            },
            {
                "cardId": "42164",
                "cardNumber": "055/197"
            },
            {
                "cardId": "42165",
                "cardNumber": "056/197"
            },
            {
                "cardId": "42166",
                "cardNumber": "057/197"
            },
            {
                "cardId": "42167",
                "cardNumber": "058/197"
            },
            {
                "cardId": "42168",
                "cardNumber": "059/197"
            },
            {
                "cardId": "42169",
                "cardNumber": "060/197"
            },
            {
                "cardId": "42170",
                "cardNumber": "061/197"
            },
            {
                "cardId": "42171",
                "cardNumber": "062/197"
            },
            {
                "cardId": "42172",
                "cardNumber": "063/197"
            },
            {
                "cardId": "42173",
                "cardNumber": "064/197"
            },
            {
                "cardId": "42174",
                "cardNumber": "065/197"
            },
            {
                "cardId": "42175",
                "cardNumber": "066/197"
            },
            {
                "cardId": "42176",
                "cardNumber": "067/197"
            },
            {
                "cardId": "42177",
                "cardNumber": "068/197"
            },
            {
                "cardId": "42178",
                "cardNumber": "069/197"
            },
            {
                "cardId": "42179",
                "cardNumber": "070/197"
            },
            {
                "cardId": "42180",
                "cardNumber": "071/197"
            },
            {
                "cardId": "42181",
                "cardNumber": "072/197"
            },
            {
                "cardId": "42182",
                "cardNumber": "073/197"
            },
            {
                "cardId": "42183",
                "cardNumber": "074/197"
            },
            {
                "cardId": "42184",
                "cardNumber": "075/197"
            },
            {
                "cardId": "42185",
                "cardNumber": "076/197"
            },
            {
                "cardId": "42186",
                "cardNumber": "077/197"
            },
            {
                "cardId": "42187",
                "cardNumber": "078/197"
            },
            {
                "cardId": "42188",
                "cardNumber": "079/197"
            },
            {
                "cardId": "42189",
                "cardNumber": "080/197"
            },
            {
                "cardId": "42190",
                "cardNumber": "081/197"
            },
            {
                "cardId": "42191",
                "cardNumber": "082/197"
            },
            {
                "cardId": "42192",
                "cardNumber": "083/197"
            },
            {
                "cardId": "42193",
                "cardNumber": "084/197"
            },
            {
                "cardId": "42194",
                "cardNumber": "085/197"
            },
            {
                "cardId": "42195",
                "cardNumber": "086/197"
            },
            {
                "cardId": "42196",
                "cardNumber": "087/197"
            },
            {
                "cardId": "42197",
                "cardNumber": "088/197"
            },
            {
                "cardId": "42198",
                "cardNumber": "089/197"
            },
            {
                "cardId": "42199",
                "cardNumber": "090/197"
            },
            {
                "cardId": "42200",
                "cardNumber": "091/197"
            },
            {
                "cardId": "42201",
                "cardNumber": "092/197"
            },
            {
                "cardId": "42202",
                "cardNumber": "093/197"
            },
            {
                "cardId": "42203",
                "cardNumber": "094/197"
            },
            {
                "cardId": "42204",
                "cardNumber": "095/197"
            },
            {
                "cardId": "42205",
                "cardNumber": "096/197"
            },
            {
                "cardId": "42206",
                "cardNumber": "097/197"
            },
            {
                "cardId": "42207",
                "cardNumber": "098/197"
            },
            {
                "cardId": "42208",
                "cardNumber": "099/197"
            },
            {
                "cardId": "42209",
                "cardNumber": "100/197"
            },
            {
                "cardId": "42210",
                "cardNumber": "101/197"
            },
            {
                "cardId": "42211",
                "cardNumber": "102/197"
            },
            {
                "cardId": "42212",
                "cardNumber": "103/197"
            },
            {
                "cardId": "42213",
                "cardNumber": "104/197"
            },
            {
                "cardId": "42214",
                "cardNumber": "105/197"
            },
            {
                "cardId": "42215",
                "cardNumber": "106/197"
            },
            {
                "cardId": "42216",
                "cardNumber": "107/197"
            },
            {
                "cardId": "42217",
                "cardNumber": "108/197"
            },
            {
                "cardId": "42218",
                "cardNumber": "109/197"
            },
            {
                "cardId": "42219",
                "cardNumber": "110/197"
            },
            {
                "cardId": "42220",
                "cardNumber": "111/197"
            },
            {
                "cardId": "42221",
                "cardNumber": "112/197"
            },
            {
                "cardId": "42222",
                "cardNumber": "113/197"
            },
            {
                "cardId": "42223",
                "cardNumber": "114/197"
            },
            {
                "cardId": "42224",
                "cardNumber": "115/197"
            },
            {
                "cardId": "42225",
                "cardNumber": "116/197"
            },
            {
                "cardId": "42226",
                "cardNumber": "117/197"
            },
            {
                "cardId": "42227",
                "cardNumber": "118/197"
            },
            {
                "cardId": "42228",
                "cardNumber": "119/197"
            },
            {
                "cardId": "42229",
                "cardNumber": "120/197"
            },
            {
                "cardId": "42230",
                "cardNumber": "121/197"
            },
            {
                "cardId": "42231",
                "cardNumber": "122/197"
            },
            {
                "cardId": "42232",
                "cardNumber": "123/197"
            },
            {
                "cardId": "42233",
                "cardNumber": "124/197"
            },
            {
                "cardId": "42234",
                "cardNumber": "125/197"
            },
            {
                "cardId": "42235",
                "cardNumber": "126/197"
            },
            {
                "cardId": "42236",
                "cardNumber": "127/197"
            },
            {
                "cardId": "42237",
                "cardNumber": "128/197"
            },
            {
                "cardId": "42238",
                "cardNumber": "129/197"
            },
            {
                "cardId": "42239",
                "cardNumber": "130/197"
            },
            {
                "cardId": "42240",
                "cardNumber": "131/197"
            },
            {
                "cardId": "42241",
                "cardNumber": "132/197"
            },
            {
                "cardId": "42242",
                "cardNumber": "133/197"
            },
            {
                "cardId": "42243",
                "cardNumber": "134/197"
            },
            {
                "cardId": "42244",
                "cardNumber": "135/197"
            },
            {
                "cardId": "42245",
                "cardNumber": "136/197"
            },
            {
                "cardId": "42246",
                "cardNumber": "137/197"
            },
            {
                "cardId": "42247",
                "cardNumber": "138/197"
            },
            {
                "cardId": "42248",
                "cardNumber": "139/197"
            },
            {
                "cardId": "42249",
                "cardNumber": "140/197"
            },
            {
                "cardId": "42250",
                "cardNumber": "141/197"
            },
            {
                "cardId": "42251",
                "cardNumber": "142/197"
            },
            {
                "cardId": "42252",
                "cardNumber": "143/197"
            },
            {
                "cardId": "42253",
                "cardNumber": "144/197"
            },
            {
                "cardId": "42254",
                "cardNumber": "145/197"
            },
            {
                "cardId": "42255",
                "cardNumber": "146/197"
            },
            {
                "cardId": "42256",
                "cardNumber": "147/197"
            },
            {
                "cardId": "42257",
                "cardNumber": "148/197"
            },
            {
                "cardId": "42258",
                "cardNumber": "149/197"
            },
            {
                "cardId": "42259",
                "cardNumber": "150/197"
            },
            {
                "cardId": "42260",
                "cardNumber": "151/197"
            },
            {
                "cardId": "42261",
                "cardNumber": "152/197"
            },
            {
                "cardId": "42262",
                "cardNumber": "153/197"
            },
            {
                "cardId": "42263",
                "cardNumber": "154/197"
            },
            {
                "cardId": "42264",
                "cardNumber": "155/197"
            },
            {
                "cardId": "42265",
                "cardNumber": "156/197"
            },
            {
                "cardId": "42266",
                "cardNumber": "157/197"
            },
            {
                "cardId": "42267",
                "cardNumber": "158/197"
            },
            {
                "cardId": "42268",
                "cardNumber": "159/197"
            },
            {
                "cardId": "42269",
                "cardNumber": "160/197"
            },
            {
                "cardId": "42270",
                "cardNumber": "161/197"
            },
            {
                "cardId": "42271",
                "cardNumber": "162/197"
            },
            {
                "cardId": "42272",
                "cardNumber": "163/197"
            },
            {
                "cardId": "42273",
                "cardNumber": "164/197"
            },
            {
                "cardId": "42274",
                "cardNumber": "165/197"
            },
            {
                "cardId": "42275",
                "cardNumber": "166/197"
            },
            {
                "cardId": "42276",
                "cardNumber": "167/197"
            },
            {
                "cardId": "42277",
                "cardNumber": "168/197"
            },
            {
                "cardId": "42278",
                "cardNumber": "169/197"
            },
            {
                "cardId": "42279",
                "cardNumber": "170/197"
            },
            {
                "cardId": "42280",
                "cardNumber": "171/197"
            },
            {
                "cardId": "42281",
                "cardNumber": "172/197"
            },
            {
                "cardId": "42282",
                "cardNumber": "173/197"
            },
            {
                "cardId": "42283",
                "cardNumber": "174/197"
            },
            {
                "cardId": "42284",
                "cardNumber": "175/197"
            },
            {
                "cardId": "42285",
                "cardNumber": "176/197"
            },
            {
                "cardId": "42286",
                "cardNumber": "177/197"
            },
            {
                "cardId": "42287",
                "cardNumber": "178/197"
            },
            {
                "cardId": "42288",
                "cardNumber": "179/197"
            },
            {
                "cardId": "42289",
                "cardNumber": "180/197"
            },
            {
                "cardId": "42290",
                "cardNumber": "181/197"
            },
            {
                "cardId": "42291",
                "cardNumber": "182/197"
            },
            {
                "cardId": "42292",
                "cardNumber": "183/197"
            },
            {
                "cardId": "42293",
                "cardNumber": "184/197"
            },
            {
                "cardId": "42294",
                "cardNumber": "185/197"
            },
            {
                "cardId": "42295",
                "cardNumber": "186/197"
            },
            {
                "cardId": "42296",
                "cardNumber": "187/197"
            },
            {
                "cardId": "42297",
                "cardNumber": "188/197"
            },
            {
                "cardId": "42298",
                "cardNumber": "189/197"
            },
            {
                "cardId": "42299",
                "cardNumber": "190/197"
            },
            {
                "cardId": "42300",
                "cardNumber": "191/197"
            },
            {
                "cardId": "42301",
                "cardNumber": "192/197"
            },
            {
                "cardId": "42302",
                "cardNumber": "193/197"
            },
            {
                "cardId": "42303",
                "cardNumber": "194/197"
            },
            {
                "cardId": "42304",
                "cardNumber": "195/197"
            },
            {
                "cardId": "42305",
                "cardNumber": "196/197"
            },
            {
                "cardId": "42306",
                "cardNumber": "197/197"
            },
            {
                "cardId": "42307",
                "cardNumber": "198/197"
            },
            {
                "cardId": "42308",
                "cardNumber": "199/197"
            },
            {
                "cardId": "42309",
                "cardNumber": "200/197"
            },
            {
                "cardId": "42310",
                "cardNumber": "201/197"
            },
            {
                "cardId": "42311",
                "cardNumber": "202/197"
            },
            {
                "cardId": "42312",
                "cardNumber": "203/197"
            },
            {
                "cardId": "42313",
                "cardNumber": "204/197"
            },
            {
                "cardId": "42314",
                "cardNumber": "205/197"
            },
            {
                "cardId": "42315",
                "cardNumber": "206/197"
            },
            {
                "cardId": "42316",
                "cardNumber": "207/197"
            },
            {
                "cardId": "42317",
                "cardNumber": "208/197"
            },
            {
                "cardId": "42318",
                "cardNumber": "209/197"
            },
            {
                "cardId": "42319",
                "cardNumber": "210/197"
            },
            {
                "cardId": "42320",
                "cardNumber": "211/197"
            },
            {
                "cardId": "42321",
                "cardNumber": "212/197"
            },
            {
                "cardId": "42322",
                "cardNumber": "213/197"
            },
            {
                "cardId": "42323",
                "cardNumber": "214/197"
            },
            {
                "cardId": "42324",
                "cardNumber": "215/197"
            },
            {
                "cardId": "42325",
                "cardNumber": "216/197"
            },
            {
                "cardId": "42326",
                "cardNumber": "217/197"
            },
            {
                "cardId": "42327",
                "cardNumber": "218/197"
            },
            {
                "cardId": "42328",
                "cardNumber": "219/197"
            },
            {
                "cardId": "42329",
                "cardNumber": "220/197"
            },
            {
                "cardId": "42330",
                "cardNumber": "221/197"
            },
            {
                "cardId": "42331",
                "cardNumber": "222/197"
            },
            {
                "cardId": "42332",
                "cardNumber": "223/197"
            },
            {
                "cardId": "42333",
                "cardNumber": "224/197"
            },
            {
                "cardId": "42334",
                "cardNumber": "225/197"
            },
            {
                "cardId": "42335",
                "cardNumber": "226/197"
            },
            {
                "cardId": "42336",
                "cardNumber": "227/197"
            },
            {
                "cardId": "42337",
                "cardNumber": "228/197"
            },
            {
                "cardId": "42338",
                "cardNumber": "229/197"
            },
            {
                "cardId": "42339",
                "cardNumber": "230/197"
            }
        ]
    },
    {
        "setPath": "/sets/11574/paldea-evolved",
        "setCode": "PAL",
        "setId": "11574",
        "totalCards": 193,
        "cards": [
            {
                "cardId": "41202",
                "cardNumber": "001/193"
            },
            {
                "cardId": "41203",
                "cardNumber": "002/193"
            },
            {
                "cardId": "41204",
                "cardNumber": "003/193"
            },
            {
                "cardId": "41205",
                "cardNumber": "004/193"
            },
            {
                "cardId": "41206",
                "cardNumber": "005/193"
            },
            {
                "cardId": "41207",
                "cardNumber": "006/193"
            },
            {
                "cardId": "41208",
                "cardNumber": "007/193"
            },
            {
                "cardId": "41209",
                "cardNumber": "008/193"
            },
            {
                "cardId": "41210",
                "cardNumber": "009/193"
            },
            {
                "cardId": "41211",
                "cardNumber": "010/193"
            },
            {
                "cardId": "41212",
                "cardNumber": "011/193"
            },
            {
                "cardId": "41213",
                "cardNumber": "012/193"
            },
            {
                "cardId": "41214",
                "cardNumber": "013/193"
            },
            {
                "cardId": "41215",
                "cardNumber": "014/193"
            },
            {
                "cardId": "41216",
                "cardNumber": "015/193"
            },
            {
                "cardId": "41217",
                "cardNumber": "016/193"
            },
            {
                "cardId": "41218",
                "cardNumber": "017/193"
            },
            {
                "cardId": "41219",
                "cardNumber": "018/193"
            },
            {
                "cardId": "41220",
                "cardNumber": "019/193"
            },
            {
                "cardId": "41221",
                "cardNumber": "020/193"
            },
            {
                "cardId": "41222",
                "cardNumber": "021/193"
            },
            {
                "cardId": "41223",
                "cardNumber": "022/193"
            },
            {
                "cardId": "41224",
                "cardNumber": "023/193"
            },
            {
                "cardId": "41225",
                "cardNumber": "024/193"
            },
            {
                "cardId": "41226",
                "cardNumber": "025/193"
            },
            {
                "cardId": "41227",
                "cardNumber": "026/193"
            },
            {
                "cardId": "41228",
                "cardNumber": "027/193"
            },
            {
                "cardId": "41229",
                "cardNumber": "028/193"
            },
            {
                "cardId": "41230",
                "cardNumber": "029/193"
            },
            {
                "cardId": "41231",
                "cardNumber": "030/193"
            },
            {
                "cardId": "41232",
                "cardNumber": "031/193"
            },
            {
                "cardId": "41233",
                "cardNumber": "032/193"
            },
            {
                "cardId": "41234",
                "cardNumber": "033/193"
            },
            {
                "cardId": "41235",
                "cardNumber": "034/193"
            },
            {
                "cardId": "41236",
                "cardNumber": "035/193"
            },
            {
                "cardId": "41237",
                "cardNumber": "036/193"
            },
            {
                "cardId": "41238",
                "cardNumber": "037/193"
            },
            {
                "cardId": "41239",
                "cardNumber": "038/193"
            },
            {
                "cardId": "41240",
                "cardNumber": "039/193"
            },
            {
                "cardId": "41241",
                "cardNumber": "040/193"
            },
            {
                "cardId": "41242",
                "cardNumber": "041/193"
            },
            {
                "cardId": "41243",
                "cardNumber": "042/193"
            },
            {
                "cardId": "41244",
                "cardNumber": "043/193"
            },
            {
                "cardId": "41245",
                "cardNumber": "044/193"
            },
            {
                "cardId": "41246",
                "cardNumber": "045/193"
            },
            {
                "cardId": "41247",
                "cardNumber": "046/193"
            },
            {
                "cardId": "41248",
                "cardNumber": "047/193"
            },
            {
                "cardId": "41249",
                "cardNumber": "048/193"
            },
            {
                "cardId": "41250",
                "cardNumber": "049/193"
            },
            {
                "cardId": "41251",
                "cardNumber": "050/193"
            },
            {
                "cardId": "41252",
                "cardNumber": "051/193"
            },
            {
                "cardId": "41253",
                "cardNumber": "052/193"
            },
            {
                "cardId": "41254",
                "cardNumber": "053/193"
            },
            {
                "cardId": "41255",
                "cardNumber": "054/193"
            },
            {
                "cardId": "41256",
                "cardNumber": "055/193"
            },
            {
                "cardId": "41257",
                "cardNumber": "056/193"
            },
            {
                "cardId": "41258",
                "cardNumber": "057/193"
            },
            {
                "cardId": "41259",
                "cardNumber": "058/193"
            },
            {
                "cardId": "41260",
                "cardNumber": "059/193"
            },
            {
                "cardId": "41261",
                "cardNumber": "060/193"
            },
            {
                "cardId": "41262",
                "cardNumber": "061/193"
            },
            {
                "cardId": "41263",
                "cardNumber": "062/193"
            },
            {
                "cardId": "41264",
                "cardNumber": "063/193"
            },
            {
                "cardId": "41265",
                "cardNumber": "064/193"
            },
            {
                "cardId": "41266",
                "cardNumber": "065/193"
            },
            {
                "cardId": "41267",
                "cardNumber": "066/193"
            },
            {
                "cardId": "41268",
                "cardNumber": "067/193"
            },
            {
                "cardId": "41269",
                "cardNumber": "068/193"
            },
            {
                "cardId": "41270",
                "cardNumber": "069/193"
            },
            {
                "cardId": "41271",
                "cardNumber": "070/193"
            },
            {
                "cardId": "41272",
                "cardNumber": "071/193"
            },
            {
                "cardId": "41273",
                "cardNumber": "072/193"
            },
            {
                "cardId": "41274",
                "cardNumber": "073/193"
            },
            {
                "cardId": "41275",
                "cardNumber": "074/193"
            },
            {
                "cardId": "41276",
                "cardNumber": "075/193"
            },
            {
                "cardId": "41277",
                "cardNumber": "076/193"
            },
            {
                "cardId": "41278",
                "cardNumber": "077/193"
            },
            {
                "cardId": "41279",
                "cardNumber": "078/193"
            },
            {
                "cardId": "41280",
                "cardNumber": "079/193"
            },
            {
                "cardId": "41281",
                "cardNumber": "080/193"
            },
            {
                "cardId": "41282",
                "cardNumber": "081/193"
            },
            {
                "cardId": "41283",
                "cardNumber": "082/193"
            },
            {
                "cardId": "41284",
                "cardNumber": "083/193"
            },
            {
                "cardId": "41285",
                "cardNumber": "084/193"
            },
            {
                "cardId": "41286",
                "cardNumber": "085/193"
            },
            {
                "cardId": "41287",
                "cardNumber": "086/193"
            },
            {
                "cardId": "41288",
                "cardNumber": "087/193"
            },
            {
                "cardId": "41289",
                "cardNumber": "088/193"
            },
            {
                "cardId": "41290",
                "cardNumber": "089/193"
            },
            {
                "cardId": "41291",
                "cardNumber": "090/193"
            },
            {
                "cardId": "41292",
                "cardNumber": "091/193"
            },
            {
                "cardId": "41293",
                "cardNumber": "092/193"
            },
            {
                "cardId": "41294",
                "cardNumber": "093/193"
            },
            {
                "cardId": "41295",
                "cardNumber": "094/193"
            },
            {
                "cardId": "41296",
                "cardNumber": "095/193"
            },
            {
                "cardId": "41297",
                "cardNumber": "096/193"
            },
            {
                "cardId": "41298",
                "cardNumber": "097/193"
            },
            {
                "cardId": "41299",
                "cardNumber": "098/193"
            },
            {
                "cardId": "41300",
                "cardNumber": "099/193"
            },
            {
                "cardId": "41301",
                "cardNumber": "100/193"
            },
            {
                "cardId": "41302",
                "cardNumber": "101/193"
            },
            {
                "cardId": "41303",
                "cardNumber": "102/193"
            },
            {
                "cardId": "41304",
                "cardNumber": "103/193"
            },
            {
                "cardId": "41305",
                "cardNumber": "104/193"
            },
            {
                "cardId": "41306",
                "cardNumber": "105/193"
            },
            {
                "cardId": "41307",
                "cardNumber": "106/193"
            },
            {
                "cardId": "41308",
                "cardNumber": "107/193"
            },
            {
                "cardId": "41309",
                "cardNumber": "108/193"
            },
            {
                "cardId": "41310",
                "cardNumber": "109/193"
            },
            {
                "cardId": "41311",
                "cardNumber": "110/193"
            },
            {
                "cardId": "41312",
                "cardNumber": "111/193"
            },
            {
                "cardId": "41313",
                "cardNumber": "112/193"
            },
            {
                "cardId": "41314",
                "cardNumber": "113/193"
            },
            {
                "cardId": "41315",
                "cardNumber": "114/193"
            },
            {
                "cardId": "41316",
                "cardNumber": "115/193"
            },
            {
                "cardId": "41317",
                "cardNumber": "116/193"
            },
            {
                "cardId": "41318",
                "cardNumber": "117/193"
            },
            {
                "cardId": "41319",
                "cardNumber": "118/193"
            },
            {
                "cardId": "41320",
                "cardNumber": "119/193"
            },
            {
                "cardId": "41321",
                "cardNumber": "120/193"
            },
            {
                "cardId": "41322",
                "cardNumber": "121/193"
            },
            {
                "cardId": "41323",
                "cardNumber": "122/193"
            },
            {
                "cardId": "41324",
                "cardNumber": "123/193"
            },
            {
                "cardId": "41325",
                "cardNumber": "124/193"
            },
            {
                "cardId": "41326",
                "cardNumber": "125/193"
            },
            {
                "cardId": "41327",
                "cardNumber": "126/193"
            },
            {
                "cardId": "41328",
                "cardNumber": "127/193"
            },
            {
                "cardId": "41329",
                "cardNumber": "128/193"
            },
            {
                "cardId": "41330",
                "cardNumber": "129/193"
            },
            {
                "cardId": "41331",
                "cardNumber": "130/193"
            },
            {
                "cardId": "41332",
                "cardNumber": "131/193"
            },
            {
                "cardId": "41333",
                "cardNumber": "132/193"
            },
            {
                "cardId": "41334",
                "cardNumber": "133/193"
            },
            {
                "cardId": "41335",
                "cardNumber": "134/193"
            },
            {
                "cardId": "41336",
                "cardNumber": "135/193"
            },
            {
                "cardId": "41337",
                "cardNumber": "136/193"
            },
            {
                "cardId": "41338",
                "cardNumber": "137/193"
            },
            {
                "cardId": "41339",
                "cardNumber": "138/193"
            },
            {
                "cardId": "41340",
                "cardNumber": "139/193"
            },
            {
                "cardId": "41341",
                "cardNumber": "140/193"
            },
            {
                "cardId": "41342",
                "cardNumber": "141/193"
            },
            {
                "cardId": "41343",
                "cardNumber": "142/193"
            },
            {
                "cardId": "41344",
                "cardNumber": "143/193"
            },
            {
                "cardId": "41345",
                "cardNumber": "144/193"
            },
            {
                "cardId": "41346",
                "cardNumber": "145/193"
            },
            {
                "cardId": "41347",
                "cardNumber": "146/193"
            },
            {
                "cardId": "41348",
                "cardNumber": "147/193"
            },
            {
                "cardId": "41349",
                "cardNumber": "148/193"
            },
            {
                "cardId": "41350",
                "cardNumber": "149/193"
            },
            {
                "cardId": "41351",
                "cardNumber": "150/193"
            },
            {
                "cardId": "41352",
                "cardNumber": "151/193"
            },
            {
                "cardId": "41353",
                "cardNumber": "152/193"
            },
            {
                "cardId": "41354",
                "cardNumber": "153/193"
            },
            {
                "cardId": "41355",
                "cardNumber": "154/193"
            },
            {
                "cardId": "41356",
                "cardNumber": "155/193"
            },
            {
                "cardId": "41357",
                "cardNumber": "156/193"
            },
            {
                "cardId": "41358",
                "cardNumber": "157/193"
            },
            {
                "cardId": "41359",
                "cardNumber": "158/193"
            },
            {
                "cardId": "41360",
                "cardNumber": "159/193"
            },
            {
                "cardId": "41361",
                "cardNumber": "160/193"
            },
            {
                "cardId": "41362",
                "cardNumber": "161/193"
            },
            {
                "cardId": "41363",
                "cardNumber": "162/193"
            },
            {
                "cardId": "41364",
                "cardNumber": "163/193"
            },
            {
                "cardId": "41365",
                "cardNumber": "164/193"
            },
            {
                "cardId": "41366",
                "cardNumber": "165/193"
            },
            {
                "cardId": "41367",
                "cardNumber": "166/193"
            },
            {
                "cardId": "41368",
                "cardNumber": "167/193"
            },
            {
                "cardId": "41369",
                "cardNumber": "168/193"
            },
            {
                "cardId": "41370",
                "cardNumber": "169/193"
            },
            {
                "cardId": "41371",
                "cardNumber": "170/193"
            },
            {
                "cardId": "41372",
                "cardNumber": "171/193"
            },
            {
                "cardId": "41373",
                "cardNumber": "172/193"
            },
            {
                "cardId": "41374",
                "cardNumber": "173/193"
            },
            {
                "cardId": "41375",
                "cardNumber": "174/193"
            },
            {
                "cardId": "41376",
                "cardNumber": "175/193"
            },
            {
                "cardId": "41377",
                "cardNumber": "176/193"
            },
            {
                "cardId": "41378",
                "cardNumber": "177/193"
            },
            {
                "cardId": "41379",
                "cardNumber": "178/193"
            },
            {
                "cardId": "41380",
                "cardNumber": "179/193"
            },
            {
                "cardId": "41381",
                "cardNumber": "180/193"
            },
            {
                "cardId": "41382",
                "cardNumber": "181/193"
            },
            {
                "cardId": "41383",
                "cardNumber": "182/193"
            },
            {
                "cardId": "41384",
                "cardNumber": "183/193"
            },
            {
                "cardId": "41385",
                "cardNumber": "184/193"
            },
            {
                "cardId": "41386",
                "cardNumber": "185/193"
            },
            {
                "cardId": "41387",
                "cardNumber": "186/193"
            },
            {
                "cardId": "41388",
                "cardNumber": "187/193"
            },
            {
                "cardId": "41389",
                "cardNumber": "188/193"
            },
            {
                "cardId": "41390",
                "cardNumber": "189/193"
            },
            {
                "cardId": "41391",
                "cardNumber": "190/193"
            },
            {
                "cardId": "41392",
                "cardNumber": "191/193"
            },
            {
                "cardId": "41393",
                "cardNumber": "192/193"
            },
            {
                "cardId": "41394",
                "cardNumber": "193/193"
            },
            {
                "cardId": "41395",
                "cardNumber": "194/193"
            },
            {
                "cardId": "41396",
                "cardNumber": "195/193"
            },
            {
                "cardId": "41397",
                "cardNumber": "196/193"
            },
            {
                "cardId": "41398",
                "cardNumber": "197/193"
            },
            {
                "cardId": "41399",
                "cardNumber": "198/193"
            },
            {
                "cardId": "41400",
                "cardNumber": "199/193"
            },
            {
                "cardId": "41401",
                "cardNumber": "200/193"
            },
            {
                "cardId": "41402",
                "cardNumber": "201/193"
            },
            {
                "cardId": "41403",
                "cardNumber": "202/193"
            },
            {
                "cardId": "41404",
                "cardNumber": "203/193"
            },
            {
                "cardId": "41405",
                "cardNumber": "204/193"
            },
            {
                "cardId": "41406",
                "cardNumber": "205/193"
            },
            {
                "cardId": "41407",
                "cardNumber": "206/193"
            },
            {
                "cardId": "41408",
                "cardNumber": "207/193"
            },
            {
                "cardId": "41409",
                "cardNumber": "208/193"
            },
            {
                "cardId": "41410",
                "cardNumber": "209/193"
            },
            {
                "cardId": "41411",
                "cardNumber": "210/193"
            },
            {
                "cardId": "41412",
                "cardNumber": "211/193"
            },
            {
                "cardId": "41413",
                "cardNumber": "212/193"
            },
            {
                "cardId": "41414",
                "cardNumber": "213/193"
            },
            {
                "cardId": "41415",
                "cardNumber": "214/193"
            },
            {
                "cardId": "41416",
                "cardNumber": "215/193"
            },
            {
                "cardId": "41417",
                "cardNumber": "216/193"
            },
            {
                "cardId": "41418",
                "cardNumber": "217/193"
            },
            {
                "cardId": "41419",
                "cardNumber": "218/193"
            },
            {
                "cardId": "41420",
                "cardNumber": "219/193"
            },
            {
                "cardId": "41421",
                "cardNumber": "220/193"
            },
            {
                "cardId": "41422",
                "cardNumber": "221/193"
            },
            {
                "cardId": "41423",
                "cardNumber": "222/193"
            },
            {
                "cardId": "41424",
                "cardNumber": "223/193"
            },
            {
                "cardId": "41425",
                "cardNumber": "224/193"
            },
            {
                "cardId": "41426",
                "cardNumber": "225/193"
            },
            {
                "cardId": "41427",
                "cardNumber": "226/193"
            },
            {
                "cardId": "41428",
                "cardNumber": "227/193"
            },
            {
                "cardId": "41429",
                "cardNumber": "228/193"
            },
            {
                "cardId": "41430",
                "cardNumber": "229/193"
            },
            {
                "cardId": "41431",
                "cardNumber": "230/193"
            },
            {
                "cardId": "41432",
                "cardNumber": "231/193"
            },
            {
                "cardId": "41433",
                "cardNumber": "232/193"
            },
            {
                "cardId": "41434",
                "cardNumber": "233/193"
            },
            {
                "cardId": "41435",
                "cardNumber": "234/193"
            },
            {
                "cardId": "41436",
                "cardNumber": "235/193"
            },
            {
                "cardId": "41437",
                "cardNumber": "236/193"
            },
            {
                "cardId": "41438",
                "cardNumber": "237/193"
            },
            {
                "cardId": "41439",
                "cardNumber": "238/193"
            },
            {
                "cardId": "41440",
                "cardNumber": "239/193"
            },
            {
                "cardId": "41441",
                "cardNumber": "240/193"
            },
            {
                "cardId": "41442",
                "cardNumber": "241/193"
            },
            {
                "cardId": "41443",
                "cardNumber": "242/193"
            },
            {
                "cardId": "41444",
                "cardNumber": "243/193"
            },
            {
                "cardId": "41445",
                "cardNumber": "244/193"
            },
            {
                "cardId": "41446",
                "cardNumber": "245/193"
            },
            {
                "cardId": "41447",
                "cardNumber": "246/193"
            },
            {
                "cardId": "41448",
                "cardNumber": "247/193"
            },
            {
                "cardId": "41449",
                "cardNumber": "248/193"
            },
            {
                "cardId": "41450",
                "cardNumber": "249/193"
            },
            {
                "cardId": "41451",
                "cardNumber": "250/193"
            },
            {
                "cardId": "41452",
                "cardNumber": "251/193"
            },
            {
                "cardId": "41453",
                "cardNumber": "252/193"
            },
            {
                "cardId": "41454",
                "cardNumber": "253/193"
            },
            {
                "cardId": "41455",
                "cardNumber": "254/193"
            },
            {
                "cardId": "41456",
                "cardNumber": "255/193"
            },
            {
                "cardId": "41457",
                "cardNumber": "256/193"
            },
            {
                "cardId": "41458",
                "cardNumber": "257/193"
            },
            {
                "cardId": "41459",
                "cardNumber": "258/193"
            },
            {
                "cardId": "41460",
                "cardNumber": "259/193"
            },
            {
                "cardId": "41461",
                "cardNumber": "260/193"
            },
            {
                "cardId": "41462",
                "cardNumber": "261/193"
            },
            {
                "cardId": "41463",
                "cardNumber": "262/193"
            },
            {
                "cardId": "41464",
                "cardNumber": "263/193"
            },
            {
                "cardId": "41465",
                "cardNumber": "264/193"
            },
            {
                "cardId": "41466",
                "cardNumber": "265/193"
            },
            {
                "cardId": "41467",
                "cardNumber": "266/193"
            },
            {
                "cardId": "41468",
                "cardNumber": "267/193"
            },
            {
                "cardId": "41469",
                "cardNumber": "268/193"
            },
            {
                "cardId": "41470",
                "cardNumber": "269/193"
            },
            {
                "cardId": "41471",
                "cardNumber": "270/193"
            },
            {
                "cardId": "41472",
                "cardNumber": "271/193"
            },
            {
                "cardId": "41473",
                "cardNumber": "272/193"
            },
            {
                "cardId": "41474",
                "cardNumber": "273/193"
            },
            {
                "cardId": "41475",
                "cardNumber": "274/193"
            },
            {
                "cardId": "41476",
                "cardNumber": "275/193"
            },
            {
                "cardId": "41477",
                "cardNumber": "276/193"
            },
            {
                "cardId": "41478",
                "cardNumber": "277/193"
            },
            {
                "cardId": "41479",
                "cardNumber": "278/193"
            },
            {
                "cardId": "41480",
                "cardNumber": "279/193"
            }
        ]
    },
    {
        "setPath": "/sets/11507/scarlet-and-violet",
        "setCode": "SVI",
        "setId": "11507",
        "totalCards": 198,
        "cards": [
            {
                "cardId": "40618",
                "cardNumber": "001/198"
            },
            {
                "cardId": "40619",
                "cardNumber": "002/198"
            },
            {
                "cardId": "40620",
                "cardNumber": "003/198"
            },
            {
                "cardId": "40621",
                "cardNumber": "004/198"
            },
            {
                "cardId": "40622",
                "cardNumber": "005/198"
            },
            {
                "cardId": "40623",
                "cardNumber": "006/198"
            },
            {
                "cardId": "40624",
                "cardNumber": "007/198"
            },
            {
                "cardId": "40625",
                "cardNumber": "008/198"
            },
            {
                "cardId": "40626",
                "cardNumber": "009/198"
            },
            {
                "cardId": "40627",
                "cardNumber": "010/198"
            },
            {
                "cardId": "40628",
                "cardNumber": "011/198"
            },
            {
                "cardId": "40629",
                "cardNumber": "012/198"
            },
            {
                "cardId": "40079",
                "cardNumber": "013/198"
            },
            {
                "cardId": "40630",
                "cardNumber": "014/198"
            },
            {
                "cardId": "40631",
                "cardNumber": "015/198"
            },
            {
                "cardId": "40632",
                "cardNumber": "016/198"
            },
            {
                "cardId": "40633",
                "cardNumber": "017/198"
            },
            {
                "cardId": "40634",
                "cardNumber": "018/198"
            },
            {
                "cardId": "40635",
                "cardNumber": "019/198"
            },
            {
                "cardId": "40636",
                "cardNumber": "020/198"
            },
            {
                "cardId": "40637",
                "cardNumber": "021/198"
            },
            {
                "cardId": "40638",
                "cardNumber": "022/198"
            },
            {
                "cardId": "40639",
                "cardNumber": "023/198"
            },
            {
                "cardId": "40640",
                "cardNumber": "024/198"
            },
            {
                "cardId": "40641",
                "cardNumber": "025/198"
            },
            {
                "cardId": "40642",
                "cardNumber": "026/198"
            },
            {
                "cardId": "40643",
                "cardNumber": "027/198"
            },
            {
                "cardId": "40644",
                "cardNumber": "028/198"
            },
            {
                "cardId": "40645",
                "cardNumber": "029/198"
            },
            {
                "cardId": "40646",
                "cardNumber": "030/198"
            },
            {
                "cardId": "40647",
                "cardNumber": "031/198"
            },
            {
                "cardId": "40648",
                "cardNumber": "032/198"
            },
            {
                "cardId": "40649",
                "cardNumber": "033/198"
            },
            {
                "cardId": "40650",
                "cardNumber": "034/198"
            },
            {
                "cardId": "40651",
                "cardNumber": "035/198"
            },
            {
                "cardId": "40080",
                "cardNumber": "036/198"
            },
            {
                "cardId": "40652",
                "cardNumber": "037/198"
            },
            {
                "cardId": "40653",
                "cardNumber": "038/198"
            },
            {
                "cardId": "40654",
                "cardNumber": "039/198"
            },
            {
                "cardId": "40655",
                "cardNumber": "040/198"
            },
            {
                "cardId": "40656",
                "cardNumber": "041/198"
            },
            {
                "cardId": "40657",
                "cardNumber": "042/198"
            },
            {
                "cardId": "40658",
                "cardNumber": "043/198"
            },
            {
                "cardId": "40659",
                "cardNumber": "044/198"
            },
            {
                "cardId": "40660",
                "cardNumber": "045/198"
            },
            {
                "cardId": "40661",
                "cardNumber": "046/198"
            },
            {
                "cardId": "40662",
                "cardNumber": "047/198"
            },
            {
                "cardId": "40663",
                "cardNumber": "048/198"
            },
            {
                "cardId": "40664",
                "cardNumber": "049/198"
            },
            {
                "cardId": "40665",
                "cardNumber": "050/198"
            },
            {
                "cardId": "40666",
                "cardNumber": "051/198"
            },
            {
                "cardId": "40081",
                "cardNumber": "052/198"
            },
            {
                "cardId": "40667",
                "cardNumber": "053/198"
            },
            {
                "cardId": "40668",
                "cardNumber": "054/198"
            },
            {
                "cardId": "40669",
                "cardNumber": "055/198"
            },
            {
                "cardId": "40670",
                "cardNumber": "056/198"
            },
            {
                "cardId": "40671",
                "cardNumber": "057/198"
            },
            {
                "cardId": "40672",
                "cardNumber": "058/198"
            },
            {
                "cardId": "40673",
                "cardNumber": "059/198"
            },
            {
                "cardId": "40674",
                "cardNumber": "060/198"
            },
            {
                "cardId": "40675",
                "cardNumber": "061/198"
            },
            {
                "cardId": "40676",
                "cardNumber": "062/198"
            },
            {
                "cardId": "40677",
                "cardNumber": "063/198"
            },
            {
                "cardId": "40678",
                "cardNumber": "064/198"
            },
            {
                "cardId": "40679",
                "cardNumber": "065/198"
            },
            {
                "cardId": "40680",
                "cardNumber": "066/198"
            },
            {
                "cardId": "40681",
                "cardNumber": "067/198"
            },
            {
                "cardId": "40682",
                "cardNumber": "068/198"
            },
            {
                "cardId": "40683",
                "cardNumber": "069/198"
            },
            {
                "cardId": "40684",
                "cardNumber": "070/198"
            },
            {
                "cardId": "40685",
                "cardNumber": "071/198"
            },
            {
                "cardId": "40686",
                "cardNumber": "072/198"
            },
            {
                "cardId": "40687",
                "cardNumber": "073/198"
            },
            {
                "cardId": "40688",
                "cardNumber": "074/198"
            },
            {
                "cardId": "40689",
                "cardNumber": "075/198"
            },
            {
                "cardId": "40690",
                "cardNumber": "076/198"
            },
            {
                "cardId": "40691",
                "cardNumber": "077/198"
            },
            {
                "cardId": "40692",
                "cardNumber": "078/198"
            },
            {
                "cardId": "40693",
                "cardNumber": "079/198"
            },
            {
                "cardId": "40694",
                "cardNumber": "080/198"
            },
            {
                "cardId": "40085",
                "cardNumber": "081/198"
            },
            {
                "cardId": "40695",
                "cardNumber": "082/198"
            },
            {
                "cardId": "40696",
                "cardNumber": "083/198"
            },
            {
                "cardId": "40697",
                "cardNumber": "084/198"
            },
            {
                "cardId": "40698",
                "cardNumber": "085/198"
            },
            {
                "cardId": "40699",
                "cardNumber": "086/198"
            },
            {
                "cardId": "40700",
                "cardNumber": "087/198"
            },
            {
                "cardId": "40701",
                "cardNumber": "088/198"
            },
            {
                "cardId": "40702",
                "cardNumber": "089/198"
            },
            {
                "cardId": "40703",
                "cardNumber": "090/198"
            },
            {
                "cardId": "40704",
                "cardNumber": "091/198"
            },
            {
                "cardId": "40705",
                "cardNumber": "092/198"
            },
            {
                "cardId": "40706",
                "cardNumber": "093/198"
            },
            {
                "cardId": "40707",
                "cardNumber": "094/198"
            },
            {
                "cardId": "40708",
                "cardNumber": "095/198"
            },
            {
                "cardId": "40709",
                "cardNumber": "096/198"
            },
            {
                "cardId": "40710",
                "cardNumber": "097/198"
            },
            {
                "cardId": "40711",
                "cardNumber": "098/198"
            },
            {
                "cardId": "40712",
                "cardNumber": "099/198"
            },
            {
                "cardId": "40713",
                "cardNumber": "100/198"
            },
            {
                "cardId": "40714",
                "cardNumber": "101/198"
            },
            {
                "cardId": "40715",
                "cardNumber": "102/198"
            },
            {
                "cardId": "40716",
                "cardNumber": "103/198"
            },
            {
                "cardId": "40717",
                "cardNumber": "104/198"
            },
            {
                "cardId": "40436",
                "cardNumber": "105/198"
            },
            {
                "cardId": "40718",
                "cardNumber": "106/198"
            },
            {
                "cardId": "40719",
                "cardNumber": "107/198"
            },
            {
                "cardId": "40720",
                "cardNumber": "108/198"
            },
            {
                "cardId": "40721",
                "cardNumber": "109/198"
            },
            {
                "cardId": "40722",
                "cardNumber": "110/198"
            },
            {
                "cardId": "40723",
                "cardNumber": "111/198"
            },
            {
                "cardId": "40724",
                "cardNumber": "112/198"
            },
            {
                "cardId": "40725",
                "cardNumber": "113/198"
            },
            {
                "cardId": "40726",
                "cardNumber": "114/198"
            },
            {
                "cardId": "40727",
                "cardNumber": "115/198"
            },
            {
                "cardId": "40728",
                "cardNumber": "116/198"
            },
            {
                "cardId": "40729",
                "cardNumber": "117/198"
            },
            {
                "cardId": "40730",
                "cardNumber": "118/198"
            },
            {
                "cardId": "40731",
                "cardNumber": "119/198"
            },
            {
                "cardId": "40732",
                "cardNumber": "120/198"
            },
            {
                "cardId": "40733",
                "cardNumber": "121/198"
            },
            {
                "cardId": "40734",
                "cardNumber": "122/198"
            },
            {
                "cardId": "40735",
                "cardNumber": "123/198"
            },
            {
                "cardId": "40736",
                "cardNumber": "124/198"
            },
            {
                "cardId": "40086",
                "cardNumber": "125/198"
            },
            {
                "cardId": "40737",
                "cardNumber": "126/198"
            },
            {
                "cardId": "40738",
                "cardNumber": "127/198"
            },
            {
                "cardId": "40739",
                "cardNumber": "128/198"
            },
            {
                "cardId": "40740",
                "cardNumber": "129/198"
            },
            {
                "cardId": "40741",
                "cardNumber": "130/198"
            },
            {
                "cardId": "40742",
                "cardNumber": "131/198"
            },
            {
                "cardId": "40743",
                "cardNumber": "132/198"
            },
            {
                "cardId": "40744",
                "cardNumber": "133/198"
            },
            {
                "cardId": "40745",
                "cardNumber": "134/198"
            },
            {
                "cardId": "40746",
                "cardNumber": "135/198"
            },
            {
                "cardId": "40747",
                "cardNumber": "136/198"
            },
            {
                "cardId": "40748",
                "cardNumber": "137/198"
            },
            {
                "cardId": "40749",
                "cardNumber": "138/198"
            },
            {
                "cardId": "40750",
                "cardNumber": "139/198"
            },
            {
                "cardId": "40751",
                "cardNumber": "140/198"
            },
            {
                "cardId": "40752",
                "cardNumber": "141/198"
            },
            {
                "cardId": "40753",
                "cardNumber": "142/198"
            },
            {
                "cardId": "40754",
                "cardNumber": "143/198"
            },
            {
                "cardId": "40755",
                "cardNumber": "144/198"
            },
            {
                "cardId": "40756",
                "cardNumber": "145/198"
            },
            {
                "cardId": "40757",
                "cardNumber": "146/198"
            },
            {
                "cardId": "40758",
                "cardNumber": "147/198"
            },
            {
                "cardId": "40759",
                "cardNumber": "148/198"
            },
            {
                "cardId": "40760",
                "cardNumber": "149/198"
            },
            {
                "cardId": "40761",
                "cardNumber": "150/198"
            },
            {
                "cardId": "40762",
                "cardNumber": "151/198"
            },
            {
                "cardId": "40763",
                "cardNumber": "152/198"
            },
            {
                "cardId": "40764",
                "cardNumber": "153/198"
            },
            {
                "cardId": "40765",
                "cardNumber": "154/198"
            },
            {
                "cardId": "40766",
                "cardNumber": "155/198"
            },
            {
                "cardId": "40767",
                "cardNumber": "156/198"
            },
            {
                "cardId": "40768",
                "cardNumber": "157/198"
            },
            {
                "cardId": "40769",
                "cardNumber": "158/198"
            },
            {
                "cardId": "40770",
                "cardNumber": "159/198"
            },
            {
                "cardId": "40771",
                "cardNumber": "160/198"
            },
            {
                "cardId": "40772",
                "cardNumber": "161/198"
            },
            {
                "cardId": "40773",
                "cardNumber": "162/198"
            },
            {
                "cardId": "40774",
                "cardNumber": "163/198"
            },
            {
                "cardId": "40775",
                "cardNumber": "164/198"
            },
            {
                "cardId": "40776",
                "cardNumber": "165/198"
            },
            {
                "cardId": "40777",
                "cardNumber": "166/198"
            },
            {
                "cardId": "40778",
                "cardNumber": "167/198"
            },
            {
                "cardId": "40779",
                "cardNumber": "168/198"
            },
            {
                "cardId": "40780",
                "cardNumber": "169/198"
            },
            {
                "cardId": "40781",
                "cardNumber": "170/198"
            },
            {
                "cardId": "40782",
                "cardNumber": "171/198"
            },
            {
                "cardId": "40783",
                "cardNumber": "172/198"
            },
            {
                "cardId": "40784",
                "cardNumber": "173/198"
            },
            {
                "cardId": "40785",
                "cardNumber": "174/198"
            },
            {
                "cardId": "40786",
                "cardNumber": "175/198"
            },
            {
                "cardId": "40787",
                "cardNumber": "176/198"
            },
            {
                "cardId": "40788",
                "cardNumber": "177/198"
            },
            {
                "cardId": "40789",
                "cardNumber": "178/198"
            },
            {
                "cardId": "40790",
                "cardNumber": "179/198"
            },
            {
                "cardId": "40791",
                "cardNumber": "180/198"
            },
            {
                "cardId": "40792",
                "cardNumber": "181/198"
            },
            {
                "cardId": "40793",
                "cardNumber": "182/198"
            },
            {
                "cardId": "40794",
                "cardNumber": "183/198"
            },
            {
                "cardId": "40795",
                "cardNumber": "184/198"
            },
            {
                "cardId": "40796",
                "cardNumber": "185/198"
            },
            {
                "cardId": "40797",
                "cardNumber": "186/198"
            },
            {
                "cardId": "40798",
                "cardNumber": "187/198"
            },
            {
                "cardId": "40799",
                "cardNumber": "188/198"
            },
            {
                "cardId": "40800",
                "cardNumber": "189/198"
            },
            {
                "cardId": "40801",
                "cardNumber": "190/198"
            },
            {
                "cardId": "40802",
                "cardNumber": "191/198"
            },
            {
                "cardId": "40803",
                "cardNumber": "192/198"
            },
            {
                "cardId": "40804",
                "cardNumber": "193/198"
            },
            {
                "cardId": "40805",
                "cardNumber": "194/198"
            },
            {
                "cardId": "40806",
                "cardNumber": "195/198"
            },
            {
                "cardId": "40807",
                "cardNumber": "196/198"
            },
            {
                "cardId": "40808",
                "cardNumber": "197/198"
            },
            {
                "cardId": "40809",
                "cardNumber": "198/198"
            },
            {
                "cardId": "40810",
                "cardNumber": "199/198"
            },
            {
                "cardId": "40811",
                "cardNumber": "200/198"
            },
            {
                "cardId": "40812",
                "cardNumber": "201/198"
            },
            {
                "cardId": "40813",
                "cardNumber": "202/198"
            },
            {
                "cardId": "40814",
                "cardNumber": "203/198"
            },
            {
                "cardId": "40815",
                "cardNumber": "204/198"
            },
            {
                "cardId": "40816",
                "cardNumber": "205/198"
            },
            {
                "cardId": "40817",
                "cardNumber": "206/198"
            },
            {
                "cardId": "40818",
                "cardNumber": "207/198"
            },
            {
                "cardId": "40819",
                "cardNumber": "208/198"
            },
            {
                "cardId": "40820",
                "cardNumber": "209/198"
            },
            {
                "cardId": "40821",
                "cardNumber": "210/198"
            },
            {
                "cardId": "40822",
                "cardNumber": "211/198"
            },
            {
                "cardId": "40823",
                "cardNumber": "212/198"
            },
            {
                "cardId": "40824",
                "cardNumber": "213/198"
            },
            {
                "cardId": "40825",
                "cardNumber": "214/198"
            },
            {
                "cardId": "40826",
                "cardNumber": "215/198"
            },
            {
                "cardId": "40827",
                "cardNumber": "216/198"
            },
            {
                "cardId": "40828",
                "cardNumber": "217/198"
            },
            {
                "cardId": "40829",
                "cardNumber": "218/198"
            },
            {
                "cardId": "40830",
                "cardNumber": "219/198"
            },
            {
                "cardId": "40831",
                "cardNumber": "220/198"
            },
            {
                "cardId": "40832",
                "cardNumber": "221/198"
            },
            {
                "cardId": "40833",
                "cardNumber": "222/198"
            },
            {
                "cardId": "40834",
                "cardNumber": "223/198"
            },
            {
                "cardId": "40835",
                "cardNumber": "224/198"
            },
            {
                "cardId": "40836",
                "cardNumber": "225/198"
            },
            {
                "cardId": "40837",
                "cardNumber": "226/198"
            },
            {
                "cardId": "40838",
                "cardNumber": "227/198"
            },
            {
                "cardId": "40839",
                "cardNumber": "228/198"
            },
            {
                "cardId": "40840",
                "cardNumber": "229/198"
            },
            {
                "cardId": "40841",
                "cardNumber": "230/198"
            },
            {
                "cardId": "40842",
                "cardNumber": "231/198"
            },
            {
                "cardId": "40843",
                "cardNumber": "232/198"
            },
            {
                "cardId": "40844",
                "cardNumber": "233/198"
            },
            {
                "cardId": "40845",
                "cardNumber": "234/198"
            },
            {
                "cardId": "40846",
                "cardNumber": "235/198"
            },
            {
                "cardId": "40847",
                "cardNumber": "236/198"
            },
            {
                "cardId": "40848",
                "cardNumber": "237/198"
            },
            {
                "cardId": "40849",
                "cardNumber": "238/198"
            },
            {
                "cardId": "40850",
                "cardNumber": "239/198"
            },
            {
                "cardId": "40851",
                "cardNumber": "240/198"
            },
            {
                "cardId": "40852",
                "cardNumber": "241/198"
            },
            {
                "cardId": "40853",
                "cardNumber": "242/198"
            },
            {
                "cardId": "40854",
                "cardNumber": "243/198"
            },
            {
                "cardId": "40855",
                "cardNumber": "244/198"
            },
            {
                "cardId": "40856",
                "cardNumber": "245/198"
            },
            {
                "cardId": "40857",
                "cardNumber": "246/198"
            },
            {
                "cardId": "40858",
                "cardNumber": "247/198"
            },
            {
                "cardId": "40859",
                "cardNumber": "248/198"
            },
            {
                "cardId": "40860",
                "cardNumber": "249/198"
            },
            {
                "cardId": "40861",
                "cardNumber": "250/198"
            },
            {
                "cardId": "40862",
                "cardNumber": "251/198"
            },
            {
                "cardId": "40863",
                "cardNumber": "252/198"
            },
            {
                "cardId": "40864",
                "cardNumber": "253/198"
            },
            {
                "cardId": "40865",
                "cardNumber": "254/198"
            },
            {
                "cardId": "40866",
                "cardNumber": "255/198"
            },
            {
                "cardId": "40867",
                "cardNumber": "256/198"
            },
            {
                "cardId": "40868",
                "cardNumber": "257/198"
            },
            {
                "cardId": "40869",
                "cardNumber": "258/198"
            }
        ]
    },
    {
        "setPath": "/sets/11568/scarlet-and-violet-energies",
        "setCode": "SVE",
        "setId": "11568",
        "totalCards": 0,
        "cards": [
            {
                "cardId": "40870",
                "cardNumber": "001"
            },
            {
                "cardId": "40871",
                "cardNumber": "002"
            },
            {
                "cardId": "40872",
                "cardNumber": "003"
            },
            {
                "cardId": "40873",
                "cardNumber": "004"
            },
            {
                "cardId": "40874",
                "cardNumber": "005"
            },
            {
                "cardId": "40875",
                "cardNumber": "006"
            },
            {
                "cardId": "40876",
                "cardNumber": "007"
            },
            {
                "cardId": "40877",
                "cardNumber": "008"
            },
            {
                "cardId": "46174",
                "cardNumber": "009"
            },
            {
                "cardId": "46175",
                "cardNumber": "010"
            },
            {
                "cardId": "46176",
                "cardNumber": "011"
            },
            {
                "cardId": "46177",
                "cardNumber": "012"
            },
            {
                "cardId": "46178",
                "cardNumber": "013"
            },
            {
                "cardId": "46179",
                "cardNumber": "014"
            },
            {
                "cardId": "46180",
                "cardNumber": "015"
            },
            {
                "cardId": "46181",
                "cardNumber": "016"
            }
        ]
    },
    {
        "setPath": "/sets/11508/sv-black-star-promos",
        "setCode": "SVP",
        "setId": "11508",
        "totalCards": 0,
        "cards": [
            {
                "cardId": "39846",
                "cardNumber": "001"
            },
            {
                "cardId": "39847",
                "cardNumber": "002"
            },
            {
                "cardId": "39848",
                "cardNumber": "003"
            },
            {
                "cardId": "40435",
                "cardNumber": "004"
            },
            {
                "cardId": "40604",
                "cardNumber": "005"
            },
            {
                "cardId": "40605",
                "cardNumber": "006"
            },
            {
                "cardId": "40606",
                "cardNumber": "007"
            },
            {
                "cardId": "40607",
                "cardNumber": "008"
            },
            {
                "cardId": "40608",
                "cardNumber": "009"
            },
            {
                "cardId": "40609",
                "cardNumber": "010"
            },
            {
                "cardId": "40610",
                "cardNumber": "011"
            },
            {
                "cardId": "40611",
                "cardNumber": "012"
            },
            {
                "cardId": "40612",
                "cardNumber": "013"
            },
            {
                "cardId": "40613",
                "cardNumber": "014"
            },
            {
                "cardId": "40614",
                "cardNumber": "015"
            },
            {
                "cardId": "40615",
                "cardNumber": "016"
            },
            {
                "cardId": "40616",
                "cardNumber": "017"
            },
            {
                "cardId": "40617",
                "cardNumber": "018"
            },
            {
                "cardId": "41481",
                "cardNumber": "019"
            },
            {
                "cardId": "41482",
                "cardNumber": "020"
            },
            {
                "cardId": "41483",
                "cardNumber": "021"
            },
            {
                "cardId": "41484",
                "cardNumber": "022"
            },
            {
                "cardId": "41485",
                "cardNumber": "023"
            },
            {
                "cardId": "41486",
                "cardNumber": "024"
            },
            {
                "cardId": "41487",
                "cardNumber": "025"
            },
            {
                "cardId": "41488",
                "cardNumber": "026"
            },
            {
                "cardId": "41489",
                "cardNumber": "027"
            },
            {
                "cardId": "41490",
                "cardNumber": "028"
            },
            {
                "cardId": "41491",
                "cardNumber": "029"
            },
            {
                "cardId": "41725",
                "cardNumber": "030"
            },
            {
                "cardId": "41726",
                "cardNumber": "031"
            },
            {
                "cardId": "41727",
                "cardNumber": "032"
            },
            {
                "cardId": "42367",
                "cardNumber": "033"
            },
            {
                "cardId": "42368",
                "cardNumber": "034"
            },
            {
                "cardId": "42369",
                "cardNumber": "035"
            },
            {
                "cardId": "42340",
                "cardNumber": "036"
            },
            {
                "cardId": "42341",
                "cardNumber": "037"
            },
            {
                "cardId": "42342",
                "cardNumber": "038"
            },
            {
                "cardId": "42343",
                "cardNumber": "039"
            },
            {
                "cardId": "42344",
                "cardNumber": "040"
            },
            {
                "cardId": "42345",
                "cardNumber": "041"
            },
            {
                "cardId": "42346",
                "cardNumber": "042"
            },
            {
                "cardId": "42347",
                "cardNumber": "043"
            },
            {
                "cardId": "42348",
                "cardNumber": "044"
            },
            {
                "cardId": "42349",
                "cardNumber": "045"
            },
            {
                "cardId": "42577",
                "cardNumber": "046"
            },
            {
                "cardId": "42578",
                "cardNumber": "047"
            },
            {
                "cardId": "42579",
                "cardNumber": "048"
            },
            {
                "cardId": "42757",
                "cardNumber": "049"
            },
            {
                "cardId": "42758",
                "cardNumber": "050"
            },
            {
                "cardId": "42580",
                "cardNumber": "051"
            },
            {
                "cardId": "42759",
                "cardNumber": "052"
            },
            {
                "cardId": "42760",
                "cardNumber": "053"
            },
            {
                "cardId": "42761",
                "cardNumber": "054"
            },
            {
                "cardId": "42762",
                "cardNumber": "055"
            },
            {
                "cardId": "42811",
                "cardNumber": "056"
            },
            {
                "cardId": "43268",
                "cardNumber": "057"
            },
            {
                "cardId": "43269",
                "cardNumber": "058"
            },
            {
                "cardId": "43270",
                "cardNumber": "059"
            },
            {
                "cardId": "43271",
                "cardNumber": "060"
            },
            {
                "cardId": "43272",
                "cardNumber": "061"
            },
            {
                "cardId": "43273",
                "cardNumber": "062"
            },
            {
                "cardId": "43274",
                "cardNumber": "063"
            },
            {
                "cardId": "43275",
                "cardNumber": "064"
            },
            {
                "cardId": "43276",
                "cardNumber": "065"
            },
            {
                "cardId": "43277",
                "cardNumber": "066"
            },
            {
                "cardId": "43280",
                "cardNumber": "067"
            },
            {
                "cardId": "43281",
                "cardNumber": "068"
            },
            {
                "cardId": "44166",
                "cardNumber": "069"
            },
            {
                "cardId": "44167",
                "cardNumber": "070"
            },
            {
                "cardId": "44168",
                "cardNumber": "071"
            },
            {
                "cardId": "44418",
                "cardNumber": "072"
            },
            {
                "cardId": "44419",
                "cardNumber": "073"
            },
            {
                "cardId": "44420",
                "cardNumber": "074"
            },
            {
                "cardId": "44169",
                "cardNumber": "075"
            },
            {
                "cardId": "44421",
                "cardNumber": "076"
            },
            {
                "cardId": "44422",
                "cardNumber": "077"
            },
            {
                "cardId": "44423",
                "cardNumber": "078"
            },
            {
                "cardId": "44424",
                "cardNumber": "079"
            },
            {
                "cardId": "44425",
                "cardNumber": "080"
            },
            {
                "cardId": "44426",
                "cardNumber": "081"
            },
            {
                "cardId": "44427",
                "cardNumber": "082"
            },
            {
                "cardId": "44428",
                "cardNumber": "083"
            },
            {
                "cardId": "44429",
                "cardNumber": "084"
            },
            {
                "cardId": "42756",
                "cardNumber": "085"
            },
            {
                "cardId": "44488",
                "cardNumber": "086"
            },
            {
                "cardId": "44490",
                "cardNumber": "087"
            },
            {
                "cardId": "44489",
                "cardNumber": "088"
            },
            {
                "cardId": "44709",
                "cardNumber": "089"
            },
            {
                "cardId": "44710",
                "cardNumber": "090"
            },
            {
                "cardId": "44711",
                "cardNumber": "091"
            },
            {
                "cardId": "44712",
                "cardNumber": "092"
            },
            {
                "cardId": "44713",
                "cardNumber": "093"
            },
            {
                "cardId": "44714",
                "cardNumber": "094"
            },
            {
                "cardId": "44715",
                "cardNumber": "095"
            },
            {
                "cardId": "44716",
                "cardNumber": "096"
            },
            {
                "cardId": "44717",
                "cardNumber": "097"
            },
            {
                "cardId": "44718",
                "cardNumber": "098"
            },
            {
                "cardId": "44847",
                "cardNumber": "099"
            },
            {
                "cardId": "44848",
                "cardNumber": "100"
            },
            {
                "cardId": "43278",
                "cardNumber": "101"
            },
            {
                "cardId": "43279",
                "cardNumber": "102"
            },
            {
                "cardId": "44849",
                "cardNumber": "103"
            },
            {
                "cardId": "44850",
                "cardNumber": "104"
            },
            {
                "cardId": "45415",
                "cardNumber": "105"
            },
            {
                "cardId": "45416",
                "cardNumber": "106"
            },
            {
                "cardId": "45417",
                "cardNumber": "107"
            },
            {
                "cardId": "45418",
                "cardNumber": "108"
            },
            {
                "cardId": "45419",
                "cardNumber": "109"
            },
            {
                "cardId": "45420",
                "cardNumber": "110"
            },
            {
                "cardId": "45421",
                "cardNumber": "111"
            },
            {
                "cardId": "45422",
                "cardNumber": "112"
            },
            {
                "cardId": "45423",
                "cardNumber": "113"
            },
            {
                "cardId": "45264",
                "cardNumber": "114"
            },
            {
                "cardId": "45265",
                "cardNumber": "115"
            },
            {
                "cardId": "45266",
                "cardNumber": "116"
            },
            {
                "cardId": "45267",
                "cardNumber": "117"
            },
            {
                "cardId": "45268",
                "cardNumber": "118"
            },
            {
                "cardId": "45269",
                "cardNumber": "119"
            },
            {
                "cardId": "45270",
                "cardNumber": "120"
            },
            {
                "cardId": "45271",
                "cardNumber": "121"
            },
            {
                "cardId": "45272",
                "cardNumber": "122"
            },
            {
                "cardId": "45273",
                "cardNumber": "123"
            },
            {
                "cardId": "44851",
                "cardNumber": "124"
            },
            {
                "cardId": "44852",
                "cardNumber": "125"
            },
            {
                "cardId": "45414",
                "cardNumber": "126"
            },
            {
                "cardId": "45274",
                "cardNumber": "127"
            },
            {
                "cardId": "45275",
                "cardNumber": "128"
            },
            {
                "cardId": "45750",
                "cardNumber": "129"
            },
            {
                "cardId": "45751",
                "cardNumber": "130"
            },
            {
                "cardId": "45752",
                "cardNumber": "131"
            },
            {
                "cardId": "45753",
                "cardNumber": "132"
            },
            {
                "cardId": "46161",
                "cardNumber": "133"
            },
            {
                "cardId": "46162",
                "cardNumber": "134"
            },
            {
                "cardId": "46163",
                "cardNumber": "135"
            },
            {
                "cardId": "46164",
                "cardNumber": "136"
            },
            {
                "cardId": "46165",
                "cardNumber": "137"
            },
            {
                "cardId": "46166",
                "cardNumber": "138"
            },
            {
                "cardId": "46167",
                "cardNumber": "139"
            },
            {
                "cardId": "46168",
                "cardNumber": "140"
            },
            {
                "cardId": "46169",
                "cardNumber": "141"
            },
            {
                "cardId": "45614",
                "cardNumber": "142"
            },
            {
                "cardId": "45615",
                "cardNumber": "143"
            },
            {
                "cardId": "46170",
                "cardNumber": "144"
            },
            {
                "cardId": "46171",
                "cardNumber": "145"
            },
            {
                "cardId": "46172",
                "cardNumber": "146"
            },
            {
                "cardId": "46173",
                "cardNumber": "147"
            },
            {
                "cardId": "45424",
                "cardNumber": "148"
            },
            {
                "cardId": "45754",
                "cardNumber": "149"
            },
            {
                "cardId": "45756",
                "cardNumber": "150"
            },
            {
                "cardId": "46591",
                "cardNumber": "151"
            },
            {
                "cardId": "46592",
                "cardNumber": "152"
            },
            {
                "cardId": "46593",
                "cardNumber": "153"
            },
            {
                "cardId": "46594",
                "cardNumber": "154"
            },
            {
                "cardId": "46595",
                "cardNumber": "155"
            },
            {
                "cardId": "46596",
                "cardNumber": "156"
            },
            {
                "cardId": "46597",
                "cardNumber": "157"
            },
            {
                "cardId": "46598",
                "cardNumber": "158"
            },
            {
                "cardId": "46599",
                "cardNumber": "159"
            },
            {
                "cardId": "46338",
                "cardNumber": "160"
            },
            {
                "cardId": "46184",
                "cardNumber": "161"
            },
            {
                "cardId": "46185",
                "cardNumber": "162"
            },
            {
                "cardId": "46605",
                "cardNumber": "163"
            },
            {
                "cardId": "46606",
                "cardNumber": "164"
            },
            {
                "cardId": "46607",
                "cardNumber": "165"
            },
            {
                "cardId": "46600",
                "cardNumber": "166"
            },
            {
                "cardId": "46601",
                "cardNumber": "177"
            },
            {
                "cardId": "45755",
                "cardNumber": "190"
            },
            {
                "cardId": "46602",
                "cardNumber": "191"
            },
            {
                "cardId": "46603",
                "cardNumber": "192"
            },
            {
                "cardId": "46604",
                "cardNumber": "No. 500"
            }
        ]
    }
]
""";
        static readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public static List<Set> GetSetList()
        {

            return JsonSerializer.Deserialize<List<Set>>(jsonString, options) ?? [];
        }
    }
}