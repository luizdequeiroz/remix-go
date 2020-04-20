using System.ComponentModel;

namespace service.Utilities.Enums
{
    public enum ServiceType
    {
        [Description("Usuário")]
        User,
        [Description("Mesa")]
        Table,
        [Description("Ficha RMX")]
        RMX,
        [Description("Ficha M&S")]
        MS,
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
        [Description("Primazia Genérica")]
        GenericAdvantage,
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
        SheetArmor,
        [Description("Capacidade em Ficha")]
        SheetCapabilitie,
        [Description("Desvantagem em Ficha")]
        SheetDisadvantage,
        [Description("Movimento Aprimorado em Ficha")]
        SheetEnhancedMove,
        [Description("Primazia Genérica em Ficha")]
        SheetGenericAdvantage,
        [Description("Item em Ficha")]
        SheetItem,
        [Description("Prática em Ficha")]
        SheetPractice,
        [Description("Proprieade e Riqueza em Ficha")]
        SheetPropertyAndRiche,
        [Description("Perícia em Ficha")]
        SheetSkill,
        [Description("Arma em Ficha")]
        SheetWeapon
    }
}
