using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimBoneDyn::serialize
	public class AnimBoneDyn : CSerializable {
		public Vec2d vec0;
		public float float1;
		public float xOffset;
		public Vec2d position;
		public Angle angle;
		public float z;
		public Vec2d scale;
		public float float6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			vec0 = s.SerializeObject<Vec2d>(vec0, name: "vec0");
			float1 = s.Serialize<float>(float1, name: "float1");
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
				xOffset = s.Serialize<float>(xOffset, name: "xOffset");
			}
			position = s.SerializeObject<Vec2d>(position, name: "position");
			angle = s.SerializeObject<Angle>(angle, name: "angle");
			z = s.Serialize<float>(z, name: "z");
			scale = s.SerializeObject<Vec2d>(scale, name: "scale");
			float6 = s.Serialize<float>(float6, name: "float6");
		}
		/*
		Example:
		00000000 00000000 00000000 00000000 3F800000 00000000 00000000 3F800000 3F800000 3F800000
		00000000 00000000 00000000 3E45FB5D BDC4D114 3FC90FDB 00000000 3F826F70 3F800000 3F800000
		00000000 00000000 00000000 3C51CAC0 BC89DB40 3FC90FDB C0800000 3F851096 3F800000 3F800000
		00000000 00000000 00000000 3F05EE23 3F34D4EB 400E27DA C0000000 3F813C5B 3F800000 3F800000
		00000000 00000000 00000000 BBF7AA6B 3F9218C6 3FC713DD C0400000 3FC8CB01 3F800000 3F800000
		00000000 00000000 00000000 BF3D2DDE BEA5EA2E 3FC46C36 00000000 3F0F24C5 3F800000 3F800000
		vec2d             x        vec2d             x        x        vec2d             x

		00000000 00000000 00000000 00000000 3F800000 00000000 00000000 3F800000 3F800000 3F800000
		00000000 00000000 00000000 3F4D0DA0 3B4360CC 3C1167BB 40A00000 3EEEA931 3F800000 3F800000

		Adv:
		00000000 00000000 00000000 3F014035 3EFD7F95 BBF572F1 00000000 3EDEA6B5 3F800000 3F800000
		
		Reordered:
		00000000 00000000 00000000 3F800000 3F800000 3F800000 00000000 00000000 3F800000 00000000
		00000000 00000000 3E45FB5D BDC4D114 3F826F70 3F800000 00000000 3FC90FDB 3F800000 00000000
		00000000 00000000 3C51CAC0 BC89DB40 3F851096 3F800000 00000000 3FC90FDB 3F800000 C0800000
		00000000 00000000 3F05EE23 3F34D4EB 3F813C5B 3F800000 00000000 400E27DA 3F800000 C0000000
		00000000 00000000 BBF7AA6B 3F9218C6 3FC8CB01 3F800000 00000000 3FC713DD 3F800000 C0400000
		00000000 00000000 BF3D2DDE BEA5EA2E 3F0F24C5 3F800000 00000000 3FC46C36 3F800000 00000000
		vec2d             vec2d             vec2d             x        x        x        x 
		*/
	}
}
