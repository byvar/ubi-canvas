﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackFrameEvents::serialize
	public class AnimTrackFrameEvents : CSerializable {
		[Serialize("unk"   )] public float unk;
		[Serialize("events")] public CList<AnimMarkerEvent> events;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(unk));
			SerializeField(s, nameof(events));
		}

		public class AnimMarkerEvent : CSerializable {
			[Serialize("type"      )] public int type;
			[Serialize("unk0"      )] public uint unk0;
			[Serialize("vec"       )] public Vector2 vec;
			[Serialize("unk1"      )] public uint unk1;
			[Serialize("eventData0")] public uint eventData0;
			[Serialize("eventData1")] public float eventData1;

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(type));
				if (Settings.s.game == Settings.Game.RL) {
					SerializeField(s, nameof(unk0));
				}
				SerializeField(s, nameof(vec));
				SerializeField(s, nameof(unk1));
				switch (type) {
					case 1: // AnimFXEvent
						SerializeField(s, nameof(eventData0));
						break;
					case 2: // AnimAnimationEvent
						break;
					case 3: // AnimGameplayEvent
						if (Settings.s.game == Settings.Game.RA) {
							SerializeField(s, nameof(eventData1));
						}
						break;
					case 4: // AnimPolylineEvent
						SerializeField(s, nameof(eventData0));
						break;
					case 5: // AnimPartitionEvent
						SerializeField(s, nameof(eventData1));
						break;
					default:
						break;
				}
			}
		}
	}
}
