using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContactCenter.Data.SeedDataMethods
{
    public class EdrsmContextSeed
    {
        public static async Task SeedAsync(EDRSMContext context)
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (!context.IdentificationTypes.Any())
            {
                var identificationTypesData = File.ReadAllText(path + @"/SeedData/identificationTypes.json");
                var identificationTypes = JsonSerializer.Deserialize<List<IdentificationType>>(identificationTypesData);
                context.IdentificationTypes.AddRange(identificationTypes);
            }

            if (!context.PreferredContactMethods.Any())
            {
                var contactMethodsData = File.ReadAllText(path + @"/SeedData/contactMethods.json");
                var contactMethods = JsonSerializer.Deserialize<List<PreferredContactMethod>>(contactMethodsData);
                context.PreferredContactMethods.AddRange(contactMethods);
            }

            if (!context.Countries.Any())
            {
                var countriesData = File.ReadAllText(path + @"/SeedData/countries.json");
                var countries = JsonSerializer.Deserialize<List<Country>>(countriesData);
                context.Countries.AddRange(countries);
            }

            if (!context.IncidentTypes.Any())
            {
                var incidentTypesData = File.ReadAllText(path + @"/SeedData/incidentTypes.json");
                var incidentTypes = JsonSerializer.Deserialize<List<IncidentType>>(incidentTypesData);
                context.IncidentTypes.AddRange(incidentTypes);
            }

            if (!context.IncidentHeadings.Any())
            {
                var incidentHeadingsData = File.ReadAllText(path + @"/SeedData/incidentHeadings.json");
                var incidentHeadings = JsonSerializer.Deserialize<List<IncidentHeading>>(incidentHeadingsData);
                context.IncidentHeadings.AddRange(incidentHeadings);
            }

            if (!context.IncidentStatuses.Any())
            {
                var incidentStatusesData = File.ReadAllText(path + @"/SeedData/incidentStatuses.json");
                var incidentStatuses = JsonSerializer.Deserialize<List<IncidentStatus>>(incidentStatusesData);
                context.IncidentStatuses.AddRange(incidentStatuses);
            }

            if (!context.Councillors.Any())
            {
                var councillorsData = File.ReadAllText(path + @"/SeedData/councillors.json");
                var councillors = JsonSerializer.Deserialize<List<Councillor>>(councillorsData);
                context.Councillors.AddRange(councillors);
            }

            if (!context.Faqs.Any())
            {
                var faqsData = File.ReadAllText(path + @"/SeedData/faqs.json");
                var faqs = JsonSerializer.Deserialize<List<Faq>>(faqsData);
                context.Faqs.AddRange(faqs);
            }

            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}
