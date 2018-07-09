using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Skill
    {
        public string name { get; set; }
        public EnumSkill ID { get; set; }

        public int cost { get; set; }

        //Effects
        public List<EnumSkillEffect> effect;

        public int damageAmount { get; set; }
        public int healAmount { get; set; }

        public Skill(EnumSkill enumName)
        {

            switch (enumName)
            {
                case EnumSkill.Fireball:
                    name = "Fireball";
                    ID = EnumSkill.Fireball;
                    cost = 3;
                    damageAmount = 10;
                    healAmount = 0;

                    effect = new List<EnumSkillEffect>();
                    effect.Add(EnumSkillEffect.DamageOther);

                    break;
                case EnumSkill.SelfHealing:
                    name = "Self Healing";
                    ID = EnumSkill.SelfHealing;
                    cost = 2;
                    damageAmount = 0;
                    healAmount = 10;

                    effect = new List<EnumSkillEffect>();
                    effect.Add(EnumSkillEffect.HealSelf);

                    break;
                case EnumSkill.Immolation:
                    name = "Immolation";
                    ID = EnumSkill.Immolation;
                    cost = 0;
                    damageAmount = 100;
                    healAmount = 0;

                    effect = new List<EnumSkillEffect>();
                    effect.Add( EnumSkillEffect.DamageSelf );
                    effect.Add(EnumSkillEffect.DamageOther);

                    break;
                default:
                    name = "None";
                    ID = EnumSkill.None;
                    cost = 0;
                    damageAmount = 0;
                    healAmount = 0;
                    effect = new List<EnumSkillEffect>();
                    break;
            }
        }

        public void castSkill(Entity caster, Entity target)
        {
            String log = caster.name + " casts " + name + "! ";

            for(int i=0; i < effect.Count; i++)
            {
                switch (effect[i])
                {
                    case EnumSkillEffect.DamageOther:
                        GameEngine.attackMagic(caster, target, this);
                        break;
                    case EnumSkillEffect.DamageSelf:
                        GameEngine.attackMagicSelf(caster, this);
                        break;
                    case EnumSkillEffect.HealOther:
                        GameEngine.heal(caster, target, this);
                        break;
                    case EnumSkillEffect.HealSelf:
                        GameEngine.healSelf(caster, this);
                        break;
                    default:
                        break;
                }
            }

            GameEngine.textBox.addLine(log);
        }
    }
}
