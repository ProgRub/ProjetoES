using ServicesLibrary.DifferentServices;

namespace ServicesLibrary
{
    public class Services
    {
        private MedicalConditionService _medicalConditionService;
        private PatientService _patientService;
        private PrescriptionItemService _prescriptionItemService;
        private PrescriptionService _prescriptionService;
        private TherapistService _therapistService;
        private TherapySessionService _therapySessionService;
        private Services()
        {
            _medicalConditionService = new MedicalConditionService();
            _patientService = new PatientService();
            _prescriptionService = new PrescriptionService();
            _prescriptionItemService = new PrescriptionItemService();
            _therapistService = new TherapistService();
            _therapySessionService = new TherapySessionService();
        }

        public static Services Instance { get; } = new Services();
    }
}