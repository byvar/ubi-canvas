using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class GFXMatAnimImpostor : BaseObject {
		[Serialize(0, "animTranslationX")] public float animTranslationX;
		[Serialize(1, "animTranslationY")] public float animTranslationY;
		[Serialize(2, "animScaleX")] public float animScaleX;
		[Serialize(3, "animScaleY")] public float animScaleY;
		[Serialize(4, "animRot")] public float animRot;
		[Serialize(5, "animIndex")] public int animIndex;
		[Serialize(6, "animTexSizeX")] public int animTexSizeX;
		[Serialize(7, "animTexSizeY")] public int animTexSizeY;
		[Serialize(8, "animBackgroundColor")] public ColorInteger animBackgroundColor;
		[Serialize(9, "animAABB")] public AABB animAABB;
		[Serialize(10, "animPhase")] public float animPhase;

		public GFXMatAnimImpostor(Reader reader) : base(reader) {
		}
	}
}
