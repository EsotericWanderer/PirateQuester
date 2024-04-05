using PirateQuester.Utils;
using PirateQuester.Utils.Chain;
using System.Numerics;

namespace PirateQuester.DFK.Contracts;

public static partial class QuestContractDefinitions
{
    public static QuestContract GetQuestContract(int questContractId, ChainEnum chain)
    {
        return DFKQuestContracts
            .FirstOrDefault(chainQ => chainQ.Chain.ChainEnum == chain).QuestContracts
            .FirstOrDefault(quest => quest.Id == questContractId);
    }

    public static QuestContract GetQuestContractFromAddress(string questContractAddress)
    {
        return DFKQuestContracts
            .SelectMany(qc => qc.QuestContracts)
            .FirstOrDefault(quest => quest.Address == questContractAddress);
    }

    public static QuestContract GetQuestV3ContractFromType(BigInteger questInstanceId, byte questType)
    {
        return DFKQuestContracts
            .SelectMany(qc => qc.QuestContracts)
            .FirstOrDefault(quest => quest.QuestInstanceId == questInstanceId && quest.QuestType == questType);
    }

    public static readonly string NULL_ADDRESS = "0x0000000000000000000000000000000000000000";

    public static readonly List<ChainQuestContracts> DFKQuestContracts = new()
    {
        new()
        {
            Chain = Constants.ChainsList.FirstOrDefault(c => c.ChainEnum == ChainEnum.DFK),
            QuestContracts = new()
            {
                new QuestContract
                {
                    Id = 0,
                    Address = "0xb8828c687Fb1C875D5acb4281C5CDf9F49fA4637",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "TRAINING_STRENGTH",
                    Category = "Training",
                    Subcategory = "Strength",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 1,
                    Address = "0x9ec92963d0387bA57D5f2D505319b1c135C6f1D3",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "TRAINING_DEXTERITY",
                    Category = "Training",
                    Subcategory = "Dexterity",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 7
                },
                new QuestContract
                {
                    Id = 2,
                    Address = "0x801b7296f106d8818DA1D04Ed769e5a76e8911fe",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "TRAINING_AGILITY",
                    Category = "Training",
                    Subcategory = "Agility",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 4
                },
                new QuestContract
                {
                    Id = 3,
                    Address = "0xE3edf52D33F2BB05DBdA5BA73903E27a9B9b7e9d",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "TRAINING_VITALITY",
                    Category = "Training",
                    Subcategory = "Vitality",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 5
                },
                new QuestContract
                {
                    Id = 4,
                    Address = "0xBD391e4641E1bce989a246602EcDC746efA9d845",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "TRAINING_ENDURANCE",
                    Category = "Training",
                    Subcategory = "Endurance",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 6
                },
                new QuestContract
                {
                    Id = 5,
                    Address = "0xD8cCf866959830a8E397442B5F7DDD790F230962",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "TRAINING_INTELLIGENCE",
                    Category = "Training",
                    Subcategory = "Intelligence",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 1
                },
                new QuestContract
                {
                    Id = 6,
                    Address = "0x0832A218c2202088A1800D424248fC689ae74600",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "TRAINING_WISDOM",
                    Category = "Training",
                    Subcategory = "Wisdom",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 2
                },
                new QuestContract
                {
                    Id = 7,
                    Address = "0x81fA8a2bfcd703dc83c5d4bEE1075899448A5CdE",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "TRAINING_LUCK",
                    Category = "Training",
                    Subcategory = "Luck",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 3
                },
                new QuestContract
                {
                    Id = 8,
                    Address = "0x75912145f5cFEfb980616FA47B2f103210FaAb94",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GOLD_MINING",
                    Category = "Mining",
                    Subcategory = "Gold",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "mining" ? hero.StaminaCurrent() * 30 : hero.StaminaCurrent() * 36),
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 3,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 9,
                    Address = "0x98b3C85ac3cC3EF36Ff25A9229857AbACE3e7410",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "CRYSTAL_MINING",
                    Category = "Mining",
                    Subcategory = "Crystal",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "mining" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => (int)Math.Clamp(Math.Ceiling(account.LockedPowerTokenBalance / 833), 1, 6),
                    QuestInstanceId = 4,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 10,
                    Address = "0x407ab39B3675f29A719476af6eb3B9E5d93969E6",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "FISHING",
                    Category = "Fishing",
                    Subcategory = "Fishing",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => hero.profession == "fishing" ? (stamina.HasValue ? stamina.Value / 5 : hero.StaminaCurrent() / 5) : hero.StaminaCurrent()/7,
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 1,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 11,
                    Address = "0xAd51199B453075C73FA106aFcAAD59f705EF7872",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "FORAGING",
                    Category = "Foraging",
                    Subcategory = "Foraging",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => hero.profession == "foraging" ? (stamina.HasValue ? stamina.Value / 5 : hero.StaminaCurrent() / 5) : hero.StaminaCurrent()/7,
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 2,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 12,
                    Address = "0x8eDA0ceA7a90E794B33708Cc0768727A1A612f3d",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-AVAX",
                    Category = "Gardening",
                    Subcategory = "Crystal-Avax",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 1
                },
                new QuestContract
                {
                    Id = 13,
                    Address = "0xC4839Fb9A5466878168EaE3fD58c647B71475b61",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-wJEWEL",
                    Category = "Gardening",
                    Subcategory = "Crystal-wJewel",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 2
                },
                new QuestContract
                {
                    Id = 14,
                    Address = "0x6FEF23498877bC4c3940ebE121dd7D138BdA4e11",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-USDC",
                    Category = "Gardening",
                    Subcategory = "Crystal-USDC",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 3
                },
                new QuestContract
                {
                    Id = 15,
                    Address = "0xdeF7cBeE7d0B62037616ee26BCAc1C8364f53476",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_ETH-USDC",
                    Category = "Gardening",
                    Subcategory = "Eth-USDC",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 4
                },
                new QuestContract
                {
                    Id = 16,
                    Address = "0xaac3933Faa3B668304C9276d10CA88853463BD42",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_wJEWEL-USDC",
                    Category = "Gardening",
                    Subcategory = "wJewel-USDC",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 5
                },
                new QuestContract
                {
                    Id = 17,
                    Address = "0x810e1fF51fDd58c474c66A31013713D1A17BF458",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-ETH",
                    Category = "Gardening",
                    Subcategory = "Crystal-Eth",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 6
                },
                new QuestContract
                {
                    Id = 18,
                    Address = "0x706916dbC3b66d89632708CC193080ea05E0534A",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-BTC.b",
                    Category = "Gardening",
                    Subcategory = "Crystal-Btc.b",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 7
                },
                new QuestContract
                {
                    Id = 19,
                    Address = "0x1fCc67a01525fd715A67bCcbF73665Fb3dBE76c7",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-KLAY",
                    Category = "Gardening",
                    Subcategory = "Crystal-Klay",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 8
                },
                new QuestContract
                {
                    Id = 20,
                    Address = "0x2A70aA48f9dBF859239ae5E7f98fe95aE27A6CD4",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_JEWEL-KLAY",
                    Category = "Gardening",
                    Subcategory = "Jewel-Klay",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 9
                },
                new QuestContract
                {
                    Id = 21,
                    Address = "0xA0d17554F09047d65E0ae0e76CD8923A9525183c",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_JEWEL-AVAX",
                    Category = "Gardening",
                    Subcategory = "Jewel-Avax",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 10
                },
                new QuestContract
                {
                    Id = 22,
                    Address = "0x3391B9384AC66C7Aa3BF4A75A4f441942B1dCf30",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_JEWEL-BTC.b",
                    Category = "Gardening",
                    Subcategory = "Jewel-Btc.b",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 11
                },
                new QuestContract
                {
                    Id = 23,
                    Address = "0xbaEc39Dd81b964B57bc5fa5f5421Cd82185409E6",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_JEWEL-ETH",
                    Category = "Gardening",
                    Subcategory = "Jewel-Eth",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 12
                },
                new QuestContract
                {
                    Id = 24,
                    Address = "0x045838dBfb8026520E872c8298F4Ed542B81Eaca",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_BTC.b-USDC",
                    Category = "Gardening",
                    Subcategory = "Btc.b-USDC",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 13
                },
                new QuestContract
                {
                    Id = 25,
                    Address = "0x407ab39B3675f29A719476af6eb3B9E5d93969E6",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "FISHING (Skill 10)",
                    Category = "Fishing",
                    Subcategory = "Fishing",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => hero.profession == "fishing" ? (stamina.HasValue ? stamina.Value / 5 : hero.StaminaCurrent() / 5) : hero.StaminaCurrent()/7,
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 1,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 26,
                    Address = "0xAd51199B453075C73FA106aFcAAD59f705EF7872",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "FORAGING (Skill 10)",
                    Category = "Foraging",
                    Subcategory = "Foraging",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => hero.profession == "foraging" ? (stamina.HasValue ? stamina.Value / 5 : hero.StaminaCurrent() / 5) : hero.StaminaCurrent()/7,
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 2,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 27,
                    Address = "0x8eDA0ceA7a90E794B33708Cc0768727A1A612f3d",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-AVAX (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Crystal-Avax",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 1
                },
                new QuestContract
                {
                    Id = 28,
                    Address = "0xC4839Fb9A5466878168EaE3fD58c647B71475b61",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-wJEWEL (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Crystal-wJewel",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 2
                },
                new QuestContract
                {
                    Id = 29,
                    Address = "0x6FEF23498877bC4c3940ebE121dd7D138BdA4e11",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-USDC (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Crystal-USDC",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 3
                },
                new QuestContract
                {
                    Id = 30,
                    Address = "0xdeF7cBeE7d0B62037616ee26BCAc1C8364f53476",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_ETH-USDC (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Eth-USDC",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 4
                },
                new QuestContract
                {
                    Id = 31,
                    Address = "0xaac3933Faa3B668304C9276d10CA88853463BD42",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_wJEWEL-USDC (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "wJewel-USDC",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 5
                },
                new QuestContract
                {
                    Id = 32,
                    Address = "0x810e1fF51fDd58c474c66A31013713D1A17BF458",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-ETH (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Crystal-Eth",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 6
                },
                new QuestContract
                {
                    Id = 33,
                    Address = "0x706916dbC3b66d89632708CC193080ea05E0534A",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-BTC.b (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Crystal-Btc.b",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 7
                },
                new QuestContract
                {
                    Id = 34,
                    Address = "0x1fCc67a01525fd715A67bCcbF73665Fb3dBE76c7",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_CRYSTAL-KLAY (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Crystal-Klay",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 8
                },
                new QuestContract
                {
                    Id = 35,
                    Address = "0x2A70aA48f9dBF859239ae5E7f98fe95aE27A6CD4",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_JEWEL-KLAY (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Jewel-Klay",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 9
                },
                new QuestContract
                {
                    Id = 36,
                    Address = "0xA0d17554F09047d65E0ae0e76CD8923A9525183c",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_JEWEL-AVAX (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Jewel-Avax",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 10
                },
                new QuestContract
                {
                    Id = 37,
                    Address = "0x3391B9384AC66C7Aa3BF4A75A4f441942B1dCf30",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_JEWEL-BTC.b (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Jewel-Btc.b",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 11
                },
                new QuestContract
                {
                    Id = 38,
                    Address = "0xbaEc39Dd81b964B57bc5fa5f5421Cd82185409E6",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_JEWEL-ETH (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Jewel-Eth",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 12
                },
                new QuestContract
                {
                    Id = 39,
                    Address = "0x045838dBfb8026520E872c8298F4Ed542B81Eaca",
                    Chain = Constants.ChainsList[(int)ChainEnum.DFK],
                    Name = "GARDENING_BTC.b-USDC (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "Btc.b-USDC",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 13
                },
            }
        },
        new()
        {
            Chain = Constants.ChainsList.FirstOrDefault(c => c.ChainEnum == ChainEnum.Klaytn),
            QuestContracts = new(){
                new QuestContract
                {
                    Id = 0,
                    Address = "0xF2143c7c8Dfca976415bDf7d37dfa63aed8Ef741",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "TRAINING_STRENGTH",
                    Category = "Training",
                    Subcategory = "Strength",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 1,
                    Address = "0x8F3acf63fd09ceCD1F387B7bC45bc245f43D4B5e",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "TRAINING_DEXTERITY",
                    Category = "Training",
                    Subcategory = "Dexterity",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 7
                },
                new QuestContract
                {
                    Id = 2,
                    Address = "0x378052bbc8D2E1819194802b8A990E7Ae43655bA",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "TRAINING_AGILITY",
                    Category = "Training",
                    Subcategory = "Agility",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 4
                },
                new QuestContract
                {
                    Id = 3,
                    Address = "0x89a60d8B332ce2Dd3bE8b170c6391F98a03a665F",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "TRAINING_VITALITY",
                    Category = "Training",
                    Subcategory = "Vitality",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 5
                },
                new QuestContract
                {
                    Id = 4,
                    Address = "0x058282847F1C8E893edcdfea5df6eb203ECA7832",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "TRAINING_ENDURANCE",
                    Category = "Training",
                    Subcategory = "Endurance",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 6
                },
                new QuestContract
                {
                    Id = 5,
                    Address = "0xe606f6548Ae34DA9065B4fee88990F239b445403",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "TRAINING_INTELLIGENCE",
                    Category = "Training",
                    Subcategory = "Intelligence",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 1
                },
                new QuestContract
                {
                    Id = 6,
                    Address = "0x80F93836811a9A7721A21D7d8751aFd6A8fC9308",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "TRAINING_WISDOM",
                    Category = "Training",
                    Subcategory = "Wisdom",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 2
                },
                new QuestContract
                {
                    Id = 7,
                    Address = "0x5C01d797d0Cc3D79c01ef98f7ffAe25E4dCEB400",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "TRAINING_LUCK",
                    Category = "Training",
                    Subcategory = "Luck",
                    Level = 1,
                    AvailableAttempts = (hero, stamina) => (int)(stamina.HasValue ? stamina/5 : hero.StaminaCurrent()/5),
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 6,
                    QuestType = 3
                },
                new QuestContract
                {
                    Id = 8,
                    Address = "0x46F036B26870188aD69877621815238D2b81bef1",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GOLD_MINING",
                    Category = "Mining",
                    Subcategory = "Gold",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "mining" ? hero.StaminaCurrent() * 30 : hero.StaminaCurrent() * 36),
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 3,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 9,
                    Address = "0x20B274262FA6da57B5Ff90498EC373c0266eF901",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "JADE_MINING",
                    Category = "Mining",
                    Subcategory = "JADE",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "mining" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => {
                        return (int)Math.Clamp(Math.Ceiling(account.LockedPowerTokenBalance / 833), 1, 6);
                    },
                    QuestInstanceId = 4,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 10,
                    Address = "0x0E7a8b035eF2FA0183a2680458818256424Bd60B",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "FISHING",
                    Category = "Fishing",
                    Subcategory = "Fishing",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => hero.profession == "fishing" ? (stamina.HasValue ? stamina.Value / 5 : hero.StaminaCurrent() / 5) : hero.StaminaCurrent()/7,
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 1,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 11,
                    Address = "0x54DaD24dDc2cC6E7616438816DE0EeFCad79B625",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "FORAGING",
                    Category = "Foraging",
                    Subcategory = "Foraging",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => hero.profession == "foraging" ? (stamina.HasValue ? stamina.Value / 5 : hero.StaminaCurrent() / 5) : hero.StaminaCurrent()/7,
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 2,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 12,
                    Address = "0x3837612f3A14C92Da8E0186AB398A753fe169dc1",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-JEWEL",
                    Category = "Gardening",
                    Subcategory = "JADE-JEWEL",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 13,
                    Address = "0xc1C01a860B841F47f8191026D9Ca8eE2F1f37ab3",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-wKLAY",
                    Category = "Gardening",
                    Subcategory = "JADE-wKLAY",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 1
                },
                new QuestContract
                {
                    Id = 14,
                    Address = "0x7643ADB5AaF129A424390CB055d6e23231fFd690",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-AVAX",
                    Category = "Gardening",
                    Subcategory = "JADE-AVAX",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 2
                },
                new QuestContract
                {
                    Id = 15,
                    Address = "0x177D9F3A92630CB8C46F169b1F99a12A7a326c45",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-oUSDT",
                    Category = "Gardening",
                    Subcategory = "JADE-oUSDT",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 3
                },
                new QuestContract
                {
                    Id = 16,
                    Address = "0x05305c97e9A2FDC0F5Ea23824c1348DEeD9Aff04",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-oBTC",
                    Category = "Gardening",
                    Subcategory = "JADE-oBTC",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 4
                },
                new QuestContract
                {
                    Id = 17,
                    Address = "0xb911F5D6F9129365d1a415DD3CBa17F0240CFA70",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-oETH",
                    Category = "Gardening",
                    Subcategory = "JADE-oETH",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 5
                },
                new QuestContract
                {
                    Id = 18,
                    Address = "0x3198f51A1c8cFC5f1FeaD58feaa19E6dFc8e9737",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-wKLAY",
                    Category = "Gardening",
                    Subcategory = "JEWEL-wKLAY",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 6
                },
                new QuestContract
                {
                    Id = 19,
                    Address = "0xDAd93871e42a11aD577E4DCa02c7C426800A47D5",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-AVAX",
                    Category = "Gardening",
                    Subcategory = "JEWEL-AVAX",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 7
                },
                new QuestContract
                {
                    Id = 20,
                    Address = "0x0831f733870e847263907F32B3367De2f47CeAf0",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-oUSDT",
                    Category = "Gardening",
                    Subcategory = "JEWEL-oUSDT",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 8
                },
                new QuestContract
                {
                    Id = 21,
                    Address = "0x85106b1aF8B0337CB39a9aacDa87849B882a3170",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-oBTC",
                    Category = "Gardening",
                    Subcategory = "JEWEL-oBTC",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 9
                },
                new QuestContract
                {
                    Id = 22,
                    Address = "0x7038F49cAA6e2f26677D237A2A40EC6354bA1eA5",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-oETH",
                    Category = "Gardening",
                    Subcategory = "JEWEL-oETH",
                    Level = 0,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 10
                },
                new QuestContract
                {
                    Id = 23,
                    Address = "0x0E7a8b035eF2FA0183a2680458818256424Bd60B",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "FISHING (Skill 10)",
                    Category = "Fishing",
                    Subcategory = "Fishing",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => hero.profession == "fishing" ? (stamina.HasValue ? stamina.Value / 5 : hero.StaminaCurrent() / 5) : hero.StaminaCurrent()/7,
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 1,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 24,
                    Address = "0x54DaD24dDc2cC6E7616438816DE0EeFCad79B625",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "FORAGING (Skill 10)",
                    Category = "Foraging",
                    Subcategory = "Foraging",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => hero.profession == "foraging" ? (stamina.HasValue ? stamina.Value / 5 : hero.StaminaCurrent() / 5) : hero.StaminaCurrent()/7,
                    BlocksPerAttempt = (hero) => 10,
                    MaxHeroesPerQuest = (account) => 6,
                    QuestInstanceId = 2,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 25,
                    Address = "0x3837612f3A14C92Da8E0186AB398A753fe169dc1",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-JEWEL (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JADE-JEWEL",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 0
                },
                new QuestContract
                {
                    Id = 26,
                    Address = "0xc1C01a860B841F47f8191026D9Ca8eE2F1f37ab3",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-wKLAY (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JADE-wKLAY",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 1
                },
                new QuestContract
                {
                    Id = 27,
                    Address = "0x7643ADB5AaF129A424390CB055d6e23231fFd690",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-AVAX (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JADE-AVAX",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 2
                },
                new QuestContract
                {
                    Id = 28,
                    Address = "0x177D9F3A92630CB8C46F169b1F99a12A7a326c45",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-oUSDT (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JADE-oUSDT",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 3
                },
                new QuestContract
                {
                    Id = 29,
                    Address = "0x05305c97e9A2FDC0F5Ea23824c1348DEeD9Aff04",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-oBTC (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JADE-oBTC",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 4
                },
                new QuestContract
                {
                    Id = 30,
                    Address = "0xb911F5D6F9129365d1a415DD3CBa17F0240CFA70",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JADE-oETH (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JADE-oETH",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 5
                },
                new QuestContract
                {
                    Id = 31,
                    Address = "0x3198f51A1c8cFC5f1FeaD58feaa19E6dFc8e9737",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-wKLAY (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JEWEL-wKLAY",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 6
                },
                new QuestContract
                {
                    Id = 32,
                    Address = "0xDAd93871e42a11aD577E4DCa02c7C426800A47D5",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-AVAX (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JEWEL-AVAX",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 7
                },
                new QuestContract
                {
                    Id = 33,
                    Address = "0x0831f733870e847263907F32B3367De2f47CeAf0",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-oUSDT (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JEWEL-oUSDT",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 8
                },
                new QuestContract
                {
                    Id = 34,
                    Address = "0x85106b1aF8B0337CB39a9aacDa87849B882a3170",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-oBTC (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JEWEL-oBTC",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 9
                },
                new QuestContract
                {
                    Id = 35,
                    Address = "0x7038F49cAA6e2f26677D237A2A40EC6354bA1eA5",
                    Chain = Constants.ChainsList[(int)ChainEnum.Klaytn],
                    Name = "GARDENING_JEWEL-oETH (Skill 10)",
                    Category = "Gardening",
                    Subcategory = "JEWEL-oETH",
                    Level = 10,
                    AvailableAttempts = (hero, stamina) => stamina.HasValue ? stamina.Value : hero.StaminaCurrent(),
                    BlocksPerAttempt = (hero) => (ulong)(hero.profession == "gardening" ? hero.StaminaCurrent() * 300 : hero.StaminaCurrent() * 360),
                    MaxHeroesPerQuest = (account) => 2,
                    QuestInstanceId = 5,
                    QuestType = 10
                },
            }
        }
    };
}
