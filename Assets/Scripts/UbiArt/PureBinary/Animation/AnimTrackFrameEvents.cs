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
			public int type;
			public uint unk0;
			public Vector2 vec;
			public uint unk1;
			public uint eventData0;
			public float eventData1;

			public void Serialize(CSerializerObject s, string name) {
				s.Serialize(ref type);
				if (Settings.s.game == Settings.Game.RL) {
					s.Serialize(ref unk0);
				}
				s.Serialize(ref vec);
				s.Serialize(ref unk1);
				switch (type) {
					case 1: // AnimFXEvent
					case 4: // AnimPolylineEvent
						s.Serialize(ref eventData0);
						break;
					case 3: // AnimGameplayEvent
					case 5: // AnimPartitionEvent
						s.Serialize(ref eventData1);
						break;
					case 2: // AnimAnimationEvent
					default:
						break;
				}
			}
		}
	}
}
