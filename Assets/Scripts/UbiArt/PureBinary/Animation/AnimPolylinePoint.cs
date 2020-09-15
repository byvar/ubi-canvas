using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolylinePoint::serialize
	public class AnimPolylinePoint : CSerializable {
		public Vec2d pos;
		public StringID name;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pos = s.SerializeObject<Vec2d>(pos, name: "pos");
			name = s.SerializeObject<StringID>(name, name: "name");
		}
	}
}
