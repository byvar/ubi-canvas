using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorSpawnBank_Template : CSerializable {
		[Serialize("list")] public CList<ActorSpawnBank_Template.ActorSpawnData> list;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(list));
		}
		public partial class ActorSpawnData : CSerializable {
			[Serialize("id"          )] public StringID id;
			[Serialize("path"        )] public Path path;
			[Serialize("recycle"     )] public bool recycle;
			[Serialize("scale"       )] public bool scale;
			[Serialize("flip"        )] public bool flip;
			[Serialize("userData"    )] public int userData;
			[Serialize("onSpawnEvent")] public Generic<Event> onSpawnEvent;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(path));
				SerializeField(s, nameof(recycle));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(flip));
				SerializeField(s, nameof(userData));
				SerializeField(s, nameof(onSpawnEvent));
			}
		}
	}
}

