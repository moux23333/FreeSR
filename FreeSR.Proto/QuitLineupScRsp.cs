namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class QuitLineupScRsp
	{
		[ProtoMember(15)] public bool IsMainline;
		[ProtoMember(2)] public int BaseAvatarId;
		[ProtoMember(12)] public int PlaneId;
		[ProtoMember(4)] public bool IsVirtual;
		[ProtoMember(1)] public int Retcode;
	}
	
}
