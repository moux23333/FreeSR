namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UpdateMechanismBarScNotify
	{
		[ProtoMember(7)] public int FloorId;
		[ProtoMember(6)] public MechanismBarInfo MechanismBarInfo;
		[ProtoMember(9)] public int PlaneId;
	}
	
}
