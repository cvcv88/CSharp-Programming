using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP_Practice2_4
{
	public class Player
	{
		/*Skill skill;

		public void SetSkill(Skill skill)
		{
			this.skill = skill;
		}
		public void UseSkill()
		{
			skill.Execute();
		}*/

		public Skill qSkill;
		public Skill eSkill;

		public void SetQSkill(Skill qskill)
		{
			this.qSkill = qskill;
		}
		public void SetESkill(Skill eskill)
		{
			this.eSkill = eskill;
		}

		public void UseQSkill()
		{
			qSkill.Execute();
		}
		public void UseESkill()
		{
			eSkill.Execute();
		}

	}
}
