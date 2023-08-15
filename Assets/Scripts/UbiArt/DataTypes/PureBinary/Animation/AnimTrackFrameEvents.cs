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
			public AnimMarkerEventType type;
			public StringID marker;
			public Vec2d posLocal;
			public StringID name;
			public bool enableFX;
			public float eventData1;
			public StringID polyline;

			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				type = s.Serialize<AnimMarkerEventType>(type, name: "type");
				marker = s.SerializeObject<StringID>(marker, name: "marker"); // matches markerStart, markerStop (in case of AnimationEvent) or FX name (in case of FX event)
				posLocal = s.SerializeObject<Vec2d>(posLocal, name: "posLocal");
				name = s.SerializeObject<StringID>(name, name: "name");
				switch (type) {
					case AnimMarkerEventType.AnimFXEvent:
						enableFX = s.Serialize<bool>(enableFX, name: "enableFX"); // true: FX on, false: FX off
						break;
					case AnimMarkerEventType.AnimAnimationEvent:
						break;
					case AnimMarkerEventType.AnimGameplayEvent:
						if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
							eventData1 = s.Serialize<float>(eventData1, name: "eventData1");
						}
						break;
					case AnimMarkerEventType.AnimPolylineEvent:
						polyline = s.SerializeObject<StringID>(polyline, name: "polyline");
						break;
					case AnimMarkerEventType.AnimPartitionEvent:
						eventData1 = s.Serialize<float>(eventData1, name: "eventData1");
						break;
					default:
						break;
				}
			}

			public enum AnimMarkerEventType : uint {
				None = 0,
				AnimFXEvent = 1,
				AnimAnimationEvent = 2,
				AnimGameplayEvent = 3,
				AnimPolylineEvent = 4,
				AnimPartitionEvent = 5,
			}
		}
	}
}
