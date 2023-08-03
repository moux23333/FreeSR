namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ScenePropInfo
	{
		[ProtoMember(8)] public int PropState;
		[ProtoMember(7)] public long CreateTimeMs;
		[ProtoMember(4)] public int LifeTimeMs;
		[ProtoMember(6)] public List<string> OPCOCDJOEGL;
		[ProtoMember(3)] public PropExtraInfo ExtraInfo;
		[ProtoMember(11)] public int PropId;
	}
	
}
