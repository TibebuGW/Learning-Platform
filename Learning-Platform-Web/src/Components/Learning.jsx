import React, {useState, useEffect} from 'react';
import Feature from './Feature';
import LearningHeader from './LearningHeader';


function Learning() {

    const [subjects, setSubjects] = useState(null);
    const [images, setImages] = useState(null);

    useEffect(() => {
        fetch('https://localhost:5001/api/subjects/8')
            .then(res => res.json())
            .then(data => {console.log(data); setSubjects(data)})

        fetch('https://localhost:5001/api/images')
            .then(res => res.json())
            .then(res => setImages(res))
            
        
    }, [])
    
    return (
        <div >

            <LearningHeader />
            
            {subjects && images && <Feature subjects={subjects} images={images}/>}
        </div>
    )
}

export default Learning
