using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackFrameEvents::serialize
	public class AnimTrackFrameEvents : CSerializable {
		public float frame;
		public CListO<AnimMarkerEvent> events;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frame = s.Serialize<float>(frame, name: "frame");
			events = s.SerializeObject<CListO<AnimMarkerEvent>>(events, name: "events");
		}

		public class AnimMarkerEvent : CSerializable {
			public int type;
			public StringID marker;
			public Vec2d posLocal;
			public StringID name;
			public uint eventData0;
			public float eventData1;

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				type = s.Serialize<int>(type, name: "type");
				marker = s.SerializeObject<StringID>(marker, name: "marker"); // matches markerStart, markerStop
				posLocal = s.SerializeObject<Vec2d>(posLocal, name: "posLocal");
				name = s.SerializeObject<StringID>(name, name: "name");
				switch (type) {
					case 1: // AnimFXEvent
						eventData0 = s.Serialize<uint>(eventData0, name: "eventData0");
						break;
					case 2: // AnimAnimationEvent
						break;
					case 3: // AnimGameplayEvent
						if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.RM) {
							eventData1 = s.Serialize<float>(eventData1, name: "eventData1");
						}
						break;
					case 4: // AnimPolylineEvent
						eventData0 = s.Serialize<uint>(eventData0, name: "eventData0");
						break;
					case 5: // AnimPartitionEvent
						eventData1 = s.Serialize<float>(eventData1, name: "eventData1");
						break;
					default:
						break;
				}
			}
		}
	}
}
