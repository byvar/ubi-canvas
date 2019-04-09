using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimPolylinePoint::serialize
	public class AnimPolylinePoint : ICSerializable {
		public Vector2 pos;
		public StringID name;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref pos);
			s.Serialize(ref this.name);
		}
	}
}
