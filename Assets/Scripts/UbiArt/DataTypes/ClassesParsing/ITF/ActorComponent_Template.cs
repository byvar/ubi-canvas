using System;

namespace UbiArt.ITF {
	public partial class ActorComponent_Template : CSerializable {
		// Prepare component for conversion or returns a new component
		public virtual ActorComponent_Template Convert(Context context, Actor_Template actor, Settings oldSettings, Settings newSettings) => this;

		public virtual ActorComponent Instantiate(Context context) {
			var tplType = GetType();
			var typeName = tplType.FullName;
			if (typeName.Contains("_Template"))
				typeName = typeName.Replace("_Template", "");

			Type type = Type.GetType(typeName);

			// Check whether the class exists
			if (type == null) throw new Exception($"Could not create instance class of component {tplType.FullName}");

			var c = (ActorComponent)Activator.CreateInstance(type);
			c.InitContext(context);
			return c;
		}
	}
}