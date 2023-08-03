namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartFinishSubMissionScNotify
	{
		[ProtoMember(2)] public int SubMissionId;
	}
	
}
