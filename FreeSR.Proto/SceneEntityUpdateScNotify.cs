namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityUpdateScNotify
	{
		[ProtoMember(11)] public List<SceneEntityInfo> EntityList;
	}

}
