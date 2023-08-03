namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneNpcInfo
	{
		[ProtoMember(14)] public NpcExtraInfo ExtraInfo;
		[ProtoMember(9)] public int NpcId;
	}
	
}
