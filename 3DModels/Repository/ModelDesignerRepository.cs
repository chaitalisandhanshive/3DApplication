﻿using _3DModels.Models;
using System;
using System.Collections.Generic;


namespace _3DModels.Repositories
{
    public class ModelDesignerRepository
    {
        private List<ModelDesigner> modelDesigners;

        public ModelDesignerRepository()
        {
            modelDesigners = new List<ModelDesigner>();
        }

        public void AddModelDesigner(ModelDesigner modelDesigner)
        {
            // You may consider generating a unique Id for the modelDesigner here.
            modelDesigners.Add(modelDesigner);
        }

        public ModelDesigner GetModelDesignerById(int id)
        {
            return modelDesigners.Find(d => d.Id == id);
        }

        public List<ModelDesigner> GetAllModelDesigners()
        {
            return modelDesigners;
        }

        public void UpdateModelDesigner(ModelDesigner updatedModelDesigner)
        {
            ModelDesigner modelDesignerToUpdate = modelDesigners.Find(d => d.Id == updatedModelDesigner.Id);
            if (modelDesignerToUpdate != null)
            {
                modelDesignerToUpdate.Name = updatedModelDesigner.Name;
                modelDesignerToUpdate.Description = updatedModelDesigner.Description;
                modelDesignerToUpdate.IsActive = updatedModelDesigner.IsActive;
                modelDesignerToUpdate.DateModified = DateTime.Now;
                modelDesignerToUpdate.LastModifiedBy = updatedModelDesigner.LastModifiedBy;
            }
        }

        public void DeleteModelDesigner(int id)
        {
            modelDesigners.RemoveAll(d => d.Id == id);
        }
    }
}
