namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityDieScNotify
	{
		[ProtoMember(15)] public List<int> EntityIdList;
	}
	
}
