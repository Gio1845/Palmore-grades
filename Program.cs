using System;

namespace operation_decisions_loops
{
    class Program
    {
            static float partialEvaluationWorkingClass = 0.25f;
            static float PartialEvaluationPractice = 0.25f;
            static float partialEvaluationParticipation = 0.10f;
            static float partialEvaluationProyect = 0.40f;
            //evaluacion Semestral
            //trabajo en clase: 15
            //practicas: 20
            //participaciones/esfuerzo:5
            //proyecto:60%
            static float SemestreEvaluationWorkingClass = 0.15f;
            static float SemestreEvaluationPractice = 0.20f;
            static float SemestreEvaluationParticipation = 0.05f;
            static float SemestreEvaluationProyect = 0.60f;
            //los limites para tener derecho a examen semestral
            static float semesterResultAvailable =12f;
            //si aprobo el alumno
            static float semesterPassTherehold = 6f; 
        static float PartialEvaluation(float workingClass, float practice, float participation, float project) {
            float PartialResult = 
            workingClass * partialEvaluationWorkingClass 
            + practice * PartialEvaluationPractice
            + participation * partialEvaluationParticipation
            + project * partialEvaluationProyect;

            return PartialResult;
        }
         static float SemesterEvaluation (float workingClass, float practice, float participation, float project) {
            float SemesterResult = 
            workingClass * SemestreEvaluationWorkingClass 
            + practice * SemestreEvaluationPractice
            + participation * SemestreEvaluationParticipation
            + project * SemestreEvaluationProyect;

            return SemesterResult;
         }

        static void Main(string[] args)
        {

            //evaluacion parcial
            //trabajo en clase: 25
            //practicas: 15
            //participaciones/esfuerzo:10
            //proyecto:40%

            float partialEvaluationWorkingClass = 0.25f;
            float PartialEvaluationPractice = 0.25f;
            float partialEvaluationParticipation = 0.10f;
            float partialEvaluationProyect = 0.40f;
            //evaluacion Semestral
            //trabajo en clase: 15
            //practicas: 20
            //participaciones/esfuerzo:5
            //proyecto:60%
            float SemestreEvaluationWorkingClass = 0.15f;
            float SemestreEvaluationPractice = 0.20f;
            float SemestreEvaluationParticipation = 0.05f;
            float SemestreEvaluationProyect = 0.60f;
             

            float Partial1Result;
            float Partial2Result;
            float SemesterResult;

            //Partial1Result = 10 * partialEvaluationWorkingClass 
            //+ 10 * partialEvaluationParticipation 
            //+ 10 * PartialEvaluationPractice  
            //+ 10 * partialEvaluationProyect;
            Partial1Result = PartialEvaluation(10f,10f,10f,10f);

            Console.WriteLine("Resutado del parcial 1 = " + Partial1Result);

            //Partial2Result = 10 * partialEvaluationWorkingClass 
            //+ 10 * partialEvaluationParticipation 
            //+ 10 * PartialEvaluationPractice  
            //+ 10 * partialEvaluationProyect;
            Partial2Result = PartialEvaluation(10f, 10f, 10f, 10f);

            Console.WriteLine("Resultado del parcial 2 = " + Partial2Result);

            //SemesterResult = Partial1Result = 10 * partialEvaluationWorkingClass 
            //+ 10 * partialEvaluationParticipation 
            //+ 10 * PartialEvaluationPractice  
            //+ 10 * partialEvaluationProyect;

            //si tiene ls 12 puntos
            if(Partial1Result + Partial2Result >= semesterResultAvailable){
                SemesterResult = SemesterEvaluation(10f, 10f, 10f, 10f);
            }
            //si no los tiene
            else{
                SemesterResult = 0f;
            }
            Console.WriteLine("Resultado final = " + SemesterResult);

            if(SemesterResult >= semesterPassTherehold){
                Console.WriteLine("el alumno esta aprobado");
            }
            else{
                Console.WriteLine("el alumno esta reprobado");
            }
        
        }
    }
}
