namespace UbiArt.ITF {
	public partial class Actor {
		public GenericFile<Actor_Template> template;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (this is Frise) return;
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;
				l.LoadFile<GenericFile<Actor_Template>>(LUA, result => {
					template = result;
					if (template != null)
						templatePickable = template.obj;
				});
			}
		}
	}
}
