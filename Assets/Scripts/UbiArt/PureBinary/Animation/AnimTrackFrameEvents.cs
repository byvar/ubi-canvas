using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackFrameEvents::serialize
	public class AnimTrackFrameEvents : ICSerializable {
		public float unk;
		public CList<AnimMarkerEvent> events;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref unk);
			s.Serialize(ref events);
		}

		public class AnimMarkerEvent : ICSerializable {
			public uint type;

			public void Serialize(CSerializerObject s, string name) {
				s.Serialize(ref type);
			}
		}
	}
}
