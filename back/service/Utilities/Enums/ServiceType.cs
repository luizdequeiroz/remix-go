using System.ComponentModel;

namespace service.Utilities.Enums
{
    public enum ServiceType
    {
        [Description("Usuário")]
        User,
        [Description("Mesa")]
        Table,
        [Description("Ficha")]
        Card,
        [Description("Jogador e Mesa")]
        PlayerTable,
        [Description("Armadura")]
        Armor,
        [Description("Capacidade")]
        Capabilitie,
        [Description("Desvantagem")]
        Disadvantage,
        [Description("Movimento Aprimorado")]
        EnhancedMove,
        [Description("Item")]
        Item,
        [Description("Prática")]
        Practice,
        [Description("Propriedade e Riqueza")]
        PropertyAndRiche,
        [Description("Perícia")]
        Skill,
        [Description("Arma")]
        Weapon,
        [Description("Armadura em Ficha")]
        CardArmor,
        [Description("Capacidade em Ficha")]
        CardCapabilitie,
        [Description("Desvantagem em Ficha")]
        CardDisadvantage,
        [Description("Movimento Aprimorado em Ficha")]
        CardEnhancedMove,
        [Description("Item em Ficha")]
        CardItem,
        [Description("Prática em Ficha")]
        CardPractice,
        [Description("Proprieade e Riqueza em Ficha")]
        CardPropertyAndRiche,
        [Description("Perícia em Ficha")]
        CardSkill,
        [Description("Arma em Ficha")]
        CardWeapon
    }
}
